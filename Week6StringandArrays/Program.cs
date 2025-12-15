string userName = "Darth Vader";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}.");

//replace
//a - 4

string updatedUserName = userName.Replace('a', '4');

Console.WriteLine(updatedUserName);