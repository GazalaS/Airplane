namespace Airplane.Models
{
    public enum Movement
    {
        forward,
        up,
        down,
        unknown
    }

    public static class ParseMovement
    {
        public static Movement GetMovement(string movement)
        {
            switch (movement)
            {
                case Constants.FORWARD:
                    return Movement.forward;
                case Constants.UP:
                    return Movement.up;
                case Constants.DOWN:
                    return Movement.down;
                default:
                    return Movement.unknown;
            }

        }
    }

   
}