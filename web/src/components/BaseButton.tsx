import { Button, ButtonProps } from "@hope-ui/solid"

function BaseButton(props: ButtonProps) {
    return (
        <Button
            size="xs"
            justifyContent="left"
            compact
            colorScheme="neutral"
            {...props}
        />
    )
}

export default BaseButton
