string parola, parolalower = "";
Console.WriteLine("Inserire la parola con caratteri maiuscoli da trasformare in minuscolo");
parola = Console.ReadLine();
for (int i = 0; i < parola.Length; i++)
{
    int ascii = (int)parola[i];
    if (ascii >= 65 && ascii <= 90)
    {
        ascii = ascii + 32;
    }
    parolalower = parolalower + (char)ascii;
}
Console.WriteLine(parolalower);
