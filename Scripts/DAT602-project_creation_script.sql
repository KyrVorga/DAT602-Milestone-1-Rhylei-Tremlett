drop database if exists `battlespire`;
create database if not exists `battlespire`;
use `battlespire`;

drop procedure if exists CreateDatabase;
delimiter //
create procedure CreateDatabase()
begin
	drop table if exists account;
	create table if not exists account (
		account_id integer not null auto_increment,
		username varchar(50) not null unique,
		email varchar(100) not null unique,
		password varchar(50) not null,
		attempts integer not null default 0,
		is_locked boolean not null default 0,
		is_logged_in boolean not null default 0,
		is_administrator boolean not null default 0,
		highscore integer not null default 0,
		constraint pk_account primary key (account_id)
	);

	drop table if exists message;
	create table if not exists message (
		message_id integer not null auto_increment,
		account_id integer not null,
		message varchar(500) not null,
		sent_time timestamp not null,
		constraint pk_message primary key (message_id),
		constraint fk_message_account foreign key (account_id)
		references account(account_id) on delete cascade
	);

	drop table if exists entity_type;
	create table if not exists entity_type (
		entity_type varchar(50) not null,
		constraint pk_entity_type primary key (entity_type)
	);

	drop table if exists terrain_type;
	create table if not exists terrain_type (
		terrain_type varchar(50) not null,
		constraint pk_terrain_type primary key (terrain_type)
	);

	drop table if exists tile;
	create table if not exists tile (
		tile_id integer not null auto_increment,
		x integer not null,
		y integer not null,
		terrain_type varchar(50) not null,
		constraint pk_tile primary key (tile_id),
		constraint fk_tile_terrain_type foreign key (terrain_type)
		references terrain_type(terrain_type) on delete cascade
	);

	drop table if exists entity;
	create table if not exists entity (
		entity_id integer not null auto_increment,
		name varchar(50),
		health integer,
		attack integer,
		defense integer,
		healing integer,
		account_id integer,
		entity_type varchar(50) not null,
		tile_id integer,
		owner_id integer,
		killscore integer,
		inventory_used tinyint,
		is_equipped boolean,
		constraint pk_entity primary key (entity_id),
		constraint fk_entity_account foreign key (account_id)
		references account(account_id) on delete cascade,
		constraint fk_entity_entity_type foreign key (entity_type)
		references entity_type(entity_type) on delete cascade,
		constraint fk_entity_tile foreign key (tile_id)
		references tile(tile_id) on delete cascade,
		constraint fk_entity_owner foreign key (owner_id)
		references entity(entity_id) on delete cascade
	);
end //
delimiter ;

drop procedure if exists GenerateMap;
delimiter //
create procedure GenerateMap( in width int, in height int)
begin
declare x int default width * -1;
declare y int default height * -1;

while x <= width do
	while y <= height do
		insert into tile (x, y, terrain_type)
        values (x, y, "ground");
		set y = y + 1;
	end while;
    set y = height * -1;
    set x = x + 1;
end while;
end //
delimter ;

drop procedure if exists InsertData;
delimiter //
create procedure InsertData()
begin
    
    -- create entity types
    insert into entity_type (entity_type)
    values 
		("player"),
		("item"),
		("monster"),
		("chest");
    
    -- create terrain types
    insert into terrain_type (terrain_type)
    values 
		("ground"),
		("wall");
    
	call GenerateMap(40, 40);


    insert into account (username, email, password, highscore)
    values 
        ("Sevro", "Sevro@howler.com", "omnis_vir_lupus", 4890),
        ("Screwface", "Screwface@howler.com", "omnis_vir_lupus", 2630),
        ("Pebble", "Pebble@howler.com", "omnis_vir_lupus", 1332),
        ("Clown", "Clown@howler.com", "omnis_vir_lupus", 1150),
        ("Thistle", "Thistle@howler.com", "omnis_vir_lupus", 879),
        ("Harpy", "Harpy@howler.com", "omnis_vir_lupus", 621),
        ("Weed", "Weed@howler.com", "omnis_vir_lupus", 482),
        ("Quinn", "Quinn@howler.com", "omnis_vir_lupus", 263),
        ("Rotback", "Rotback@howler.com", "omnis_vir_lupus", 158);
        
	insert into account (username, email, password, is_administrator)
    values 
		('KyrVorga', 'kyrvorga@mail.com', 'omnis-vir-lupus', true);
    
    -- add chests on the map
    insert into entity (entity_type, tile_id)
    values
		("chest", 832),
		("chest", 4230),
		("chest", 2812),
		("chest", 1352),
		("chest", 3214),
		("chest", 5890);
    
    -- add some items into chests
    insert into entity (name, health, attack, defense, healing, entity_type, owner_id)
    values
		("Sword IV", 0, 200, 0, 0, "item", 1),
		("Shield II", 0, 0, 50, 0, "item", 1),
		("Amulet IV", 0, 0, 0, 200, "item", 1),
		("Armor III", 100, 0, 0, 0, "item", 2),
		("Sword II", 0, 50, 0, 0, "item", 2),
		("Shield I", 0, 0, 25, 0, "item", 3),
		("Amulet VI", 0, 0, 0, 1000, "item", 3),
		("Sword I", 0, 25, 0, 0, "item", 3),
		("Armor V", 500, 0, 0, 0, "item", 3),
		("Shield III", 0, 0, 100, 0, "item", 3),
		("Sword IV", 0, 200, 0, 0, "item", 4),
		("Shield II", 0, 0, 50, 0, "item", 4),
		("Amulet IV", 0, 0, 0, 200, "item", 4),
		("Armor III", 100, 0, 0, 0, "item", 5),
		("Sword II", 0, 50, 0, 0, "item", 5),
		("Shield I", 0, 0, 25, 0, "item", 6),
		("Amulet VI", 0, 0, 0, 1000, "item", 6),
		("Sword I", 0, 25, 0, 0, "item", 6),
		("Armor V", 500, 0, 0, 0, "item", 6),
		("Shield III", 0, 0, 100, 0, "item", 6);
        
    -- update inventory_used of chests, this would be done in a procedure as the item is made.
    update entity
    set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = 1)
    where entity_id = 1;
    
    update entity
    set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = 2)
    where entity_id = 2;
    
    update entity
    set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = 3)
    where entity_id = 3;
    
	update entity
    set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = 4)
    where entity_id = 4;
    
	update entity
    set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = 5)
    where entity_id = 5;
    
	update entity
    set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = 6)
    where entity_id = 6;
    
    -- add monsters to the map
    insert into entity (name, health, attack, defense, healing, entity_type, tile_id)
    values
		("Goblin I", 250, 25, 25, 25, "monster", 4213),
		("Goblin I", 250, 25, 25, 25, "monster", 532),
		("Goblin II", 500, 50, 50, 50, "monster", 1235),
		("Goblin II", 500, 50, 50, 50, "monster", 3262),
		("Goblin III", 1000, 100, 100, 100, "monster", 863),
		("Goblin III", 1000, 100, 100, 100, "monster", 6113),
		("Goblin IV", 2500, 250, 250, 250, "monster", 2379),
		("Goblin IV", 2500, 250, 250, 250, "monster", 34);
        
    
    -- select tile_id from tile where x = 0 and y = 0;
    
    -- create some players add various stages of progress
    insert into entity (account_id, health, attack, defense, healing, entity_type, tile_id)
	values
		(4, 250, 25, 25, 25, "player", 3281),
		(5, 250, 25, 25, 25, "player", 462),
		(6, 250, 25, 25, 25, "player", 1692),
		(7, 250, 25, 25, 25, "player", 4023),
		(8, 250, 25, 25, 25, "player", 5893);
    
    -- move some items to the players inventory
    call MoveItemToPlayer(4, 7);
    call MoveItemToPlayer(4, 8);
    call MoveItemToPlayer(4, 9);
    
    call MoveItemToPlayer(6, 22);
    call MoveItemToPlayer(6, 23);
    call MoveItemToPlayer(6, 24);
    call MoveItemToPlayer(6, 25);
    call MoveItemToPlayer(6, 26);

  
    -- add some messages sent by the players
	insert into message (account_id, message, sent_time)
    values 
		(1, "hello", current_timestamp()),
		(2, "Hey!", current_timestamp()),
		(3, "Ya-hallo!", current_timestamp()),
		(4, "Osu~", current_timestamp()),
		(5, "Sup.", current_timestamp());
        
        -- select * from message;
        -- select * from entity;
end //
delimiter ;

-- select * from account;
-- select * from entity;
-- select * from entity where entity_type = "player" and account_id = 4;


call CreateDatabase();
-- call InsertData();