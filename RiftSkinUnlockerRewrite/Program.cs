using System;

namespace RiftSkinUnlockerRewrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rift skin unlocker!\nThis was made by ozymandias to unlock skins in Rift!\n\nPress any key to continue...");
            Console.ReadKey(true);
            PatchService.Init();
        }
    }
}
