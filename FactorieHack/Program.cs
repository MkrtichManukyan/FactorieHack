
using FactorieHack;
using System;
using System.Reflection;


static void ListOfVar(GinuKonyakiFactorie ginuKonyakiFactorie)
{
    Console.WriteLine(new string('_', 30) + "Information about GinuKonyakiFactorie \n");
    Type t = ginuKonyakiFactorie.GetType();

    Console.WriteLine($"Full name       {t.FullName}");
    Console.WriteLine($"Base class      {t.BaseType}");
    Console.WriteLine($"IsAbstract      {t.IsAbstract}");
    Console.WriteLine($"IsCOM object    {t.IsCOMObject}");
    Console.WriteLine($"Is Sealed       {t.IsSealed}");
    Console.WriteLine($"Is class        {t.IsClass}");
}

static void ListOfMethods(GinuKonyakiFactorie ginuKonyakiFactorie)
{
    Console.WriteLine(new string('_', 30) + "Information about Methods \n");
    Type type = ginuKonyakiFactorie.GetType();

    MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Instance
                                    | BindingFlags.Static
                                    | BindingFlags.Public
                                    | BindingFlags.NonPublic
                                    | BindingFlags.DeclaredOnly);
    foreach (var methodInfo in methodInfos)
    {
        Console.WriteLine($"Method     {methodInfo.Name}");
    }
}

static void ListOfField(GinuKonyakiFactorie ginuKonyakiFactorie)
{
    Console.WriteLine(new string('_', 30) + "Information about Fields \n");
    Type type = ginuKonyakiFactorie.GetType();

    FieldInfo[] fields = type.GetFields(BindingFlags.Instance
        | BindingFlags.Static
        | BindingFlags.Public
        | BindingFlags.NonPublic);

    foreach (var field in fields)
    {
        Console.WriteLine($"Field      {field.Name}");
    }
}

static void ListOfConstructors(GinuKonyakiFactorie ginuKonyakiFactorie)
{
    Console.WriteLine(new string('_', 30) + "Information about Constructors \n");
    Type type = ginuKonyakiFactorie.GetType();

    ConstructorInfo[] ctors = type.GetConstructors();

    foreach (var ctor in ctors)
    {
        Console.WriteLine($"Constructor     {ctor.Name}");
    }
}

GinuKonyakiFactorie factorie = new GinuKonyakiFactorie();

ListOfVar(factorie);
ListOfMethods(factorie);
ListOfField(factorie);
ListOfConstructors(factorie);


Console.WriteLine(new string('_', 50));

Gini gini = new Gini();


Type giniFild = gini.GetType();

FieldInfo[] fieldInfo = giniFild.GetFields(
        BindingFlags.NonPublic |
        BindingFlags.Instance);

foreach (var field in fieldInfo)
{
    Console.WriteLine($"Field      {field.GetValue(gini)}");
}

Console.WriteLine(new string('_', 30));

Konyak konyak = new Konyak();


Type konyakFild = konyak.GetType();

FieldInfo[] konyakInfo = konyakFild.GetFields(
        BindingFlags.NonPublic |
        BindingFlags.Instance);

foreach (var field in konyakInfo)
{
    Console.WriteLine($"Field      {field.GetValue(konyak)}");
}

Console.WriteLine(new string('_', 30));

GinuMasnaget ginuMasnaget = new GinuMasnaget();

Type ginuMasnagetFild = ginuMasnaget.GetType();

FieldInfo[] ginuMasnagetInfo = ginuMasnagetFild.GetFields(
        BindingFlags.NonPublic |
        BindingFlags.Instance);

foreach (var field in ginuMasnagetInfo)
{
    Console.WriteLine($"Field      {field.GetValue(ginuMasnaget)}");
}

Console.WriteLine(new string('_', 30));

KonyakiMasnaget konyakiMasnaget = new KonyakiMasnaget();

Type konyakiMasnagetFild = konyakiMasnaget.GetType();

FieldInfo[] konyakiMasnagetInfo = konyakiMasnagetFild.GetFields(
        BindingFlags.NonPublic |
        BindingFlags.Instance);

foreach (var field in konyakiMasnagetInfo)
{
    Console.WriteLine($"Field      {field.GetValue(konyakiMasnaget)}");
}

Console.WriteLine(new string('_', 30));


Type typeGini = typeof(GinuMasnaget);

string methodNameGini = "_patrastum";

MethodInfo methodInfoGini = typeGini.GetMethod(methodNameGini, BindingFlags.NonPublic | BindingFlags.Instance);

methodInfoGini.Invoke(ginuMasnaget, new object[] { "xaxox" });

Console.WriteLine(methodInfoGini);


Console.WriteLine(new string('_', 30));


Type type = typeof(KonyakiMasnaget);

string methodName = "_patrastum";

MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

methodInfo.Invoke(konyakiMasnaget, new object[] { "xaxox" });

Console.WriteLine(methodInfo);