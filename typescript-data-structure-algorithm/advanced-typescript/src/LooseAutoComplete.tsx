import React from 'react'

type LooseAutoComplete<T extends string> = T | Omit<string, T>
type IconSize = LooseAutoComplete<'sm' | 'xs'>

interface IConProps {
    size: IconSize
}

export const Icon = (props: IConProps) => {
    return <div>ok</div>
}

export const Comp1 = () => {
    return (
        <>
            <Icon size="sm" />
            <Icon size="xs" />
        </>
    )
}
