﻿using System;

public class Messages
{
	public enum ClientPackets : int {
		USER_LOGGING = 1,
		USER_LEFT,
		USER_SPAWNED,
		USER_MOVEMENT,
		USER_RELOGGING,
		USER_LOCATION,
		UPDATE_LOCATION,
		ACTION,
		STOPPED_DANCING,
		UPDATE_ENV,
		UPDATE_AI,
		PING_OK,
		PICKUP_ITEM,
		USE_ITEM,
		DROPPED_ITEM,
		UNUSE_ITEM,
		UPDATE_AI_LOCATION,
		AI_DETECTED_PLAYER,
		AI_LOST_PLAYER,
		AI_ATTACK_PLAYER,
		AI_STOPPED_ATTACK
	}

	public enum ServerPackets: int {
		LOGGING_ACCEPT = 1,
		DISCONNECTED,
		MOVE,
		RUN,
		STOP,
		UPDATE_LOCATION,
		UPDATE_PLAYER,
		NEW_PLAYER,
		PLAYER_MOVE,
		PLAYER_RUN,
		PLAYER_STOP,
		PLAYER_ACTION,
		PLAYER_DISCONNECTED,
		SPAWN_AI,
		UPDATE_AI,
		PING_OK,
		MOVE_TO_LOBBY,
		INVENTOREY,
		FLOOR_ITEM,
		PICK_ITEM_OK,
		FLOOR_ITEM_REMOVE,
		USE_ITEM_OK,
		PLAYER_PICKED_ITEM,
		PLAYER_USED_ITEM,
		PLAYER_UNUSED_ITEM,
		PLAYER_DROPPED_ITEM,
		AI_CHASING_PLAYER,
		AI_STOPPED,
		AI_LOCATION,
		AI_ATTACK,
		AI_STOP_ATTACK
	}

	public enum MovementTypes : int {
		STOPPED = 0,
		WALKING,
		RUNNING
	}
	public enum ClientActions : int {
		IDLE = 0,
		DANCING,
		STOPPED_DANCING
	}

}


