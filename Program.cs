using System;
using System.Threading;

namespace ICE_Task_4_Delegates_Short_Story
{
    // Scroll of destiny — the delegate
    delegate void ScrollOfDestiny(string message);

    class Program
    {
        static void Main()
        {
            Console.Title = "Sir Delegate of the House Callback";

            void Tell(string line)
            {
                Console.WriteLine(line);
                Console.ReadLine(); // Wait for user to press Enter
            }

            // Start of story
            Console.WriteLine("\n      /| ________________" +
                              "\nO|===|* >________________>" +
                              "\n      \\|");
            Tell("Once upon a time… there was a knight named Maxine who wanted to learn about delegates in Programming C, the sharp version.");
            Tell("She decided to talk to the Never-Ending Sea about her delegateesssee.");
            Tell("The Never-Ending Sea stated, profoundingly:");

            // Show animated jellyfish before the Sea speaks
            Console.WriteLine("     .-\"\"-.\n    / .--. \\\n   / /    \\ \\\n   | |    | |\n   | |.-\"\"-.|\n  ///`.o ~ o.`\\\n ||| ::  || ::;\n ||; ::__||__::;\n  \\\\\\ '----' /\n   `=':-..-'`");

        Tell("\t\n“Delegates are like scrolls of destiny... They point to a method, but never judge the method.”");
            Tell("Maxine blinked. “So, like a royal assistant?”");
            Tell("The sea bubbled thoughtfully. “More like a fancy method butler. You tell it what kind of message you want it to carry, and it just politely calls the method on your behalf. No sass. Just execution.”");

            Tell("Maxine squinted at a floating jellyfish. “So… I can send different knights to do different things using the same scroll?”");

            Tell("The sea shimmered, “Yes! As long as their sword-swinging technique — I mean, method signature — is the same!”");
            Tell("Maxine jumped with joy. “I shall call it Sir Delegate of the House Callback!”");
            Tell("“Just don’t marry it to an async void,” the sea murmured darkly. “That path leads to chaos, lost logs, and deeply unhelpful bugs.”");
            Tell("Maxine gasped. “You mean…”");
            Tell("“Yes,” the sea said gravely, “even the ocean cannot catch exceptions in async void.”");

            Tell("         _______________\r\n    ()==(              (@==()\r\n         '______________'|\r\n           |             |\r\n           |             |\r\n         __)_____________|\r\n    ()==(               (@==()\r\n         '--------------'");

            Tell("Maxine scribbled everything in her legendary grimoire titled *How to Train Your Code*.");
            Tell("And from that day on, whenever the kingdom needed something done quickly and flexibly, they’d just say:");
            Tell("“Send a delegate.”");

            Tell("And the delegate would gallop off into memory, delivering methods faster than a caffeine-fueled debugger. " +
                "\n,~~_\r\n|/\\ =_ _ ~\r\n _( )_( )\\~~\r\n \\,\\  _|\\ \\~~~\r\n    \\`   \\\r\n    `    `");

            Tell("The End.");
        }
    }
}
