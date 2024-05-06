export type Event =
    | {
          type: 'LOG_IN'
          payload: {
              userId: string
          }
      }
    | {
          type: 'LOGOUT'
      }

const sendEvent = <Type extends Event['type']>(
    ...args: Extract<Event, { type: Type }> extends { payload: infer TPayload }
        ? [type: Type, payload: TPayload]
        : [type: Type]
) => {}

sendEvent('LOG_IN', {
    userId: '123',
})
sendEvent('LOGOUT')
