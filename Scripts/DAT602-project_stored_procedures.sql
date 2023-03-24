use battlespire;

drop procedure if exists GetPlayerID;
delimiter //
create procedure GetPlayerID(in account_id int, out player_id int)
begin

select e.entity_id
into player_id
from entity e
where e.entity_type = "player"
and e.account_id = account_id;

end //
delimiter ;

drop procedure if exists GetChestIDFromTile;
delimiter //
create procedure GetChestIDFromTile(in tile_id int, out chest_id int)
begin

select e.entity_id
into chest_id
from entity e
where e.entity_type = "chest"
and e.tile_id = tile_id;

end //
delimiter ;


drop procedure if exists GetChestIDFromItem;
delimiter //
create procedure GetChestIDFromItem(in item_id int, out chest_id int)
begin

select e.owner_id
into chest_id
from entity e
where e.entity_type = "item"
and e.entity_id = item_id;

end //
delimiter ;



-- procedure should take an account_id and an item_id, it should change the owner_id,
-- then update the inventory_used of the player and the chest the item came from.
drop procedure if exists MoveItemToPlayer;
delimiter //
create procedure MoveItemToPlayer(in account_id int, in item_id int)
begin
declare player_id int;
declare chest_id int;

-- get the ids of the player and chest that contains the item.
call GetPlayerID(account_id, player_id);
call GetChestIDFromItem(item_id, chest_id);


-- move the item to the player
update entity
set owner_id = player_id
where entity_id = item_id;

-- update player inventory
update entity
set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = player_id)
where entity_id = player_id;

-- update chest inventory
update entity
set inventory_used = (select count(entity_id) from (select * from entity) as e where owner_id = chest_id)
where entity_id = chest_id;

end //
delimiter ;