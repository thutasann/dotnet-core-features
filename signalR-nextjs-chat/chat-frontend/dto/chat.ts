export interface JoinRoomRes {
  user: string
  room: string
}

export enum ChatInvokes {
  JOIN_ROOM = 'JoinRoom',
  SEND_MESSAGE = 'SendMessage',
}
