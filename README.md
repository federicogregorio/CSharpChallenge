# CSharpChallenge
Challenge using C# language

Task 1: Logger:
Challenge\LogEvents.cs contains the logic
Challenge\Program.cs, here you can see an example into the comments where I called the logger

Task 1.1: Tests
Challenge.Tests\UnitTest1.cs, here you can see some unit test that I create for the logger using Nunit

LogMessage_ShouldLogInfoLevelMessage - I'm testing differents kinds of loglevel
LogMessage_NotLogging - I'm testing that if I use an invalid logleve, the file is not created
LogMessage_DateMatch - I'm testing the date is in the file
LogMessage_MultipleLogs - I'm testing that If I added more than 1 log

I used dotnet test command to run the test.

Task 2: Inventory Management
Challenge\InventoryManagement.cs contains 2 classes (Product and Inventory) with the sort funcionality
Challenge\Program.cs, here you can see the example with Example Input and Excepted Output that you provided me

