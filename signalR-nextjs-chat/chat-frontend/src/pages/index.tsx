import Chat from '@/components/chat/Chat'
import { Lobby } from '@/components/chat/Lobby'
import { useRecoilValue } from 'recoil'
import { ConnectionState } from '../../states/ChatStates'

export default function Home() {
  const connection = useRecoilValue(ConnectionState)

  return <main className="mx-auto max-w-[900px] p-4">{connection ? <Chat /> : <Lobby />}</main>
}
