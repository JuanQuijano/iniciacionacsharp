Console.Clear();

/*
Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97
*/

/*Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A*/

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


decimal sophiaSum = 0;
decimal nicolasSum = 0;
decimal zahirahSum = 0;
decimal jeongSum = 0;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


/*Console.WriteLine("Student\tGrade\n");
Console.WriteLine("Sophia:\t\t" + (sophiaSum / currentAssignments) + "\tA");
Console.WriteLine("Nicolas:\t" + (nicolasSum / currentAssignments) + "\tB");
Console.WriteLine("Zahirah:\t" + (zahirahSum / currentAssignments) + "\tB");
Console.WriteLine("Jeong:\t\t" + (jeongSum / currentAssignments) + "\tA");*/

Console.WriteLine(@"Student   Grade");
Console.WriteLine(@"Sophia:   " + (sophiaSum / currentAssignments) + "   A");
Console.WriteLine(@"Nicolas:  " + (nicolasSum / currentAssignments) + "   B");
Console.WriteLine(@"Zahirah:  " + (zahirahSum / currentAssignments) + "   B");
Console.WriteLine(@"Jeong:    " + (jeongSum / currentAssignments) + "   A");


