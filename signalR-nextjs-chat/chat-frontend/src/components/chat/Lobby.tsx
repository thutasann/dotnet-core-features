import { zodResolver } from '@hookform/resolvers/zod'
import { useForm } from 'react-hook-form'
import { z } from 'zod'
import { Button } from '@/components/ui/button'
import { Form, FormControl, FormField, FormItem, FormLabel } from '@/components/ui/form'
import { Input } from '@/components/ui/input'
import { formSchema } from '../../../dto/form-schema'
import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr'
import { SOCKET_BASE } from '@/lib/utils'
import { useToast } from '../ui/use-toast'
import { ChatInvokes, JoinRoomRes } from '../../../dto/chat'
import { useRecoilState } from 'recoil'
import { ConnectionState } from '../../../states/ConnectionState'

export function Lobby() {
  const [connection, setConnection] = useRecoilState(ConnectionState)

  const { toast } = useToast()
  const form = useForm<z.infer<typeof formSchema>>({
    resolver: zodResolver(formSchema),
    defaultValues: {
      user: '',
      room: '',
    },
  })

  const onSubmit = async (values: z.infer<typeof formSchema>) => {
    const { user, room } = values
    try {
      const connection = new HubConnectionBuilder()
        .withUrl(SOCKET_BASE + 'chat')
        .configureLogging(LogLevel.Information)
        .build()

      connection.on('ReceiveMessage', (user, message) => {
        console.log('message received: ', user, message)
      })

      await connection.start()
      await connection.invoke<JoinRoomRes>(ChatInvokes.JOIN_ROOM, { user, room })
      setConnection(connection)
    } catch (error) {
      toast({
        title: 'Something went wrong in joining',
        variant: 'destructive',
      })
    }
  }

  return (
    <Form {...form}>
      <h1 className="font-extrabold mb-2 text-2xl">Lobby</h1>
      <form onSubmit={form.handleSubmit(onSubmit)} className="space-y-8">
        <FormField
          control={form.control}
          name="user"
          render={({ field }) => (
            <FormItem>
              <FormLabel>Username</FormLabel>
              <FormControl>
                <Input placeholder="Enter UserName..." {...field} />
              </FormControl>
            </FormItem>
          )}
        />
        <FormField
          control={form.control}
          name="room"
          render={({ field }) => (
            <FormItem>
              <FormLabel>Room</FormLabel>
              <FormControl>
                <Input placeholder="Enter Room.." {...field} />
              </FormControl>
            </FormItem>
          )}
        />
        <Button type="submit">Submit</Button>
      </form>
    </Form>
  )
}
