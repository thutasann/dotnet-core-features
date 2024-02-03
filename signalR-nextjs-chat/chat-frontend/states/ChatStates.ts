import { type HubConnection } from '@microsoft/signalr'
import { atom } from 'recoil'

export const ConnectionState = atom<HubConnection | null>({
  key: 'ConnectionState',
  default: null,
})

export const MessagesState = atom<
  Array<{
    user: string
    message: string
  }>
>({
  key: 'MessagesState',
  default: [],
})
