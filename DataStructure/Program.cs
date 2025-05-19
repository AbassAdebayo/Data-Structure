// See https://aka.ms/new-console-template for more information
using DataStructure;

//List<string> fruits = new List<string>();
//List<string> names = new List<string>();


//fruits.Add("Banana");
//fruits.Add("Orange");
//fruits.Add("Grapes");
//fruits.Add("Pineapple");
//fruits.Add("Mango");
//fruits.Add("Apple");
//fruits.Add("Agbalumo");

//fruits.Remove("Banana");

//foreach(var fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

//Dictionary

//Dictionary<string, List<char>> studentScores = new Dictionary<string, List<char>>
//{
//    {"Bila", new List<char> {'A', 'B', 'A', 'D'} },
//    {"Tunde", new List<char> {'A', 'B', 'A', 'D'} },
//    {"Roheemah", new List<char> {'A', 'B', 'A', 'D'} },
//    {"Ola", new List<char> {'A', 'B', 'A', 'D'} }
//};


//studentScores.Add("Dele", new List<char> { 'B', 'A', 'C'});


//foreach (var student in studentScores)
//{
//    Console.WriteLine($"{student.Key}");

//    foreach(var score in student.Value)
//    {
//        Console.WriteLine($" Score: {score}");
//    }
//}

//var studentsScore = new Dictionary<string, Dictionary<string, double>>
//{
//    { "Bilal", new Dictionary<string, double> {{"Math", 90 }, {"Eng", 79},{"Chem", 88.7} }},
//    {"Ade", new Dictionary<string, double> { {"Math", 90 }, {"Eng", 89.7 }, { "Chem", 88.6} } },
//    {"Bimpe", new Dictionary<string, double> { { "Math", 70 }, {"Eng", 67.0}, { "Chem", 78.5 } } }
//};

//studentsScore.Add("Bilal", new Dictionary<string, double>
//{
//    {"Math", 77 },
//    {"Eng", 89 },
//    {"Chem", 99.6 }
//});

//studentsScore.Add("Ade", new Dictionary<string, double>
//{
//    {"Math", 79 },
//    {"Eng", 89.6 },
//    {"Chem", 91.6 }
//});

//studentsScore.Add("Tunde", new Dictionary<string, double>
//{
//    {"Math", 76.8 },
//    {"Eng", 89.7 },
//    {"Chem", 91.6 }
//});


//foreach(var student in studentsScore)
//{
//    Console.WriteLine($"{student.Key}");

//    foreach(var score in student.Value)
//    {
//        Console.WriteLine($" {score.Key}: {score.Value}");
//    }
//}

int[] numbers = new int[5];
ArrayResize arrayResize = new ArrayResize();

arrayResize.ResizeArray(numbers);

