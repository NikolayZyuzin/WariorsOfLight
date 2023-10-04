'sdfImports System.Runtime.Remoting.Channels
'Imports System.Security

Imports System.Runtime.CompilerServices

Module Module1
    Public name As String
    Public nickname As String
    Public clan As String
    Public answer As String
    Sub Main(args As String())
        Console.WriteLine("Write your name, please: ")
        name = Console.ReadLine()
        Console.WriteLine($"Okay, {name}, do you want to start a game? (put Yes or No), but remember, everything should start from a capital letter!!!")
        answer = Console.ReadLine()
        Dim timeStarted = DateTime.Now
        If answer = "Yes" Then
            Console.WriteLine("The story is: ")
            Console.WriteLine("This is a medieval world with different strange creatures and something like that. ")
            Console.WriteLine("We've got some clans for example: Warriors of Light, The Guardians of the Dawn and Werewolves with Skate the Cheater of the Death")
            Console.WriteLine("Please write the letter L for Warriors of Light, G for Guardians of the Dawn and W for Werewolves.")
            clan = Console.ReadLine()
            If clan = "L" Then
                Console.WriteLine($"{name}, you have chosen the Warriors of Light.")
                Console.WriteLine("This organisation's leader is magister Inder of Jerra, but your clan is the west army, so your leader is Berta Geskier. Warriors of light are also called a shield of Gahidga and they are defending the human world from monsters or demons. You are in Europe.")
                Console.WriteLine($"{name}, please write your character's name.")
                nickname = Console.ReadLine()
                Console.WriteLine($"Hello, {nickname}, welcome to the west army, your clan and some other armies (Central, North) came into the Gryphon Valley to protect it from a Darion the defiler's army. In your clan there are 5 more people including Berta (Henri, Josephine, Alexandre, Hugo)")
                Console.WriteLine("We are ready to start.")
                Console.WriteLine("  ")
                Console.WriteLine("  ")
                Console.WriteLine("[Berta] - Okay, guys, we have some tasks to do. First we have to get some help from a water lord and help from a forest lord.")
                Console.WriteLine("[Berta] - You can choose, where to go.")
                Console.WriteLine("[Alexandre] - To the water lord.")
                Console.WriteLine("[Hugo] - I'll go to the forest lord.")
                Console.WriteLine("[Henri] - I want to go to the lake.")
                Console.WriteLine("[Josephine] - I'll go to the forest.")
                Console.WriteLine($"{nickname}, where do you want to go? (Write F for the forest and W for the water)")
                answer = Console.ReadLine()
                If answer = "F" Then
                    Console.WriteLine("[You] - I want to go to the forest.")
                    Console.WriteLine("Later in the forest...")
                ElseIf answer = "W" Then
                    Console.WriteLine("[You] - I want to go to the lake.")
                    Console.WriteLine("Later near the lake...")
                Else
                    Console.WriteLine("ERRRrrORRrRR......")
                    Console.WriteLine("Connection problems...")
                    Console.WriteLine("Ops :(")
                    Console.WriteLine("You're out.")
                    Console.WriteLine("If this problem occurs frequently, get knowledge how to solve it)).")
                End If
            ElseIf clan = "G" Then
                Console.WriteLine($"{name}, you have chosen the Guardians of the Dawn.")
                Console.WriteLine("This clan is known as a Sword of Gahidga and you are in Japan. Guardians are separated to several parts, your squad is called Fire Scorpio, your leader is called Shadow, he has rang 6.")
                Console.WriteLine("Guardians has a type of magic called arrows, they can use them from rang 2. Every warrior has a unreal name, for example Resurrected or Shadow, but you can't use Shadow because only the leader has it.")
                Console.WriteLine("Write your unreal name, please.")
                nickname = Console.ReadLine()
                If nickname = "Shadow" Then
                    Console.WriteLine("Please, follow the rules. ")
                    nickname = Console.ReadLine()
                    If nickname = "Shadow" Then
                        Console.WriteLine("You're not following the rules. You're not playing.")
                        Console.WriteLine("Go away!")
                    End If
                End If
            ElseIf clan = "W" Then
                Dim wolf = "Wolf"
                Dim humanwolf = "0"
                Console.WriteLine("This is the werewolves clan, the leader is Skate the cheater of the death. You can turn into a wolf and back at any time you want, you just need to jump over your sword, to do this you need to write a key word Wolf")
                Console.WriteLine("You are on british islands.")
            End If
        Else
            Console.writeline($"Come back, {name}!")
        End If
        Dim timeFinished = Date.Now
        Console.WriteLine($"Well done, {name}, you finished in {timeFinished - timeStarted}!")
        Console.WriteLine("To finish, press any key.")
        Console.ReadKey(True)
    End Sub

End Module
