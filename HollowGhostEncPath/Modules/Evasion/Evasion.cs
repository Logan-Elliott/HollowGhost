namespace HollowGhostEncPath.Modules.Evasion
{
    internal class Evasion
    {
        // Perform for loop 900 million times, this is not a lot for a modern CPU but is enough to trick up an emulator, continue execution flow after complete
        public static void MI()
        {
            int count = 0;
            int max = 900000000;
            for (int i = 0; i < max; i++)
            {
                count++;
            }
            if (count == max)
            {
                return;
            }
        }
    }
}
