
# <p align = "center"> Programação pra quem tem pressa ⁉️</p>

### <p align = "center">Descobrindo o C# atraves de blocos de código</p>

<br/>

# 1️⃣ Primeira Regra
<p align='center'>
          <img src='https://user-images.githubusercontent.com/72531277/144302532-3317d7d9-00dc-4817-9915-6176373ca777.jpeg' width='300'/>
</p>

# 2️⃣ Segunda Regra

Pratique bastante.

Use esse guia como pesquisa para poder compreender na prática o funcionamento da linguagem, mas não esqueça que praticar é fundamental para fixar o aprendizado. 

Ah, não sou a favor do **Go Horse**, só um pouco preguiçosa quando se trata de ler toda aquela documentação, mas assumo que foi através dela que consegui
reunir todo esse compilado de informações, então não dispenso seu uso. Contudo, penso que a linguagem técnica das *documentações*, apesar de necessária, acaba assustando aqueles que tem pouco conhecimento ou que estão buscando através dela, ingressar na linguagem.

Por isso, o objetivo desse projeto é facilitar o aprendizado através de exemplos práticos, então fique a vontade para deixar a sua contribuição ou trocar idéias. 

🔴 Esse é um repositório publico de aprendizado, então dispensa lincensa. **Faça bom uso!** 



# 📑 Conteudos

* [Variáveis](#variaveis)
* [Conversão de tipos](#conversao)
* [Tamanho de string](#tamanho)




  # 🔻 <a name="variaveis">Variaveis<a>
<br/>


```c#
class MainClass {

  // Value type
  enum myEnum { Zero, One };

  static void Main () {

    // Value types
    bool myBool = true; // True or false
    byte myByte = 255; // 0 to 255
    char myChar = 'a'; // U +0000 to U +ffff
    decimal myDecimal = 1m; // 128-bit decimal values       
    double myDouble = 1d; // 64-bit double-precision
    float myFloat = 1f; // 32-bit single-precision
    int myInt = 1; // -2,147,483,648 to 2,147,483,647
    long myLong = 1L; // 64-bit signed integer type
    sbyte mySbyte = 1; // -128 to 127                 
    short myShort = 1; // -32,768 to 32,767 
    uint myUint = 1; // 0 to 4,294,967,295           
    ulong myUlong = 1; // 0 to 18,446,744,073,709,551,615
    ushort myUshort = 1; // 0 to 65,535

    // Reference types 
    dynamic myDynamic = 1; // Bypass compile-time type checking 
    object myObject = new myClass();
    string myString = "test";

  }

  // Reference type
  class myClass { };
  interface myInterface { };
  delegate void myDelegate();
}
```
  
# 🔻 <a name="conversao">Conversão de tipos<a>
          
```c#
Convert.ToBoolean(x);    // Converts a type to a Boolean value
Convert.ToByte(x);       // Converts a type to a byte
Convert.ToChar(x);       // Converts a type to a single Unicode character
Convert.ToDateTime(x);   // Converts a type (integer or string type) to date-time structures
Convert.ToDecimal(x);    // Converts a floating point or integer type to a decimal type
Convert.ToDouble(x);     // Converts a type to a double type
Convert.ToInt16(x);      // Converts a type to a 16-bit integer
Convert.ToInt32(x);      // Converts a type to a 32-bit integer
Convert.ToInt64(x);      // Converts a type to a 64-bit integer
Convert.ToSbyte(x);      // Converts a type to a signed byte type
Convert.ToSingle(x);     // Converts a type to a small floating point number
Convert.ToString(x);     // Converts a type to a string
Convert.ToType(x);       // Converts a type to a specified type
Convert.ToUInt16(x);     // Converts a type to an unsigned int type
Convert.ToUInt32(x);     // Converts a type to an unsigned long type
Convert.ToUInt64(x);     // Converts a type to an unsigned big integer
```
<br/>
          
          
# 🔻 <a name="operadores">Operadores<a>
          
```c#
// Arithmetic Operators
x + y   // Adds two operands
x - y   // Subtracts second operand from the first
x * y   // Multiplies both operands
x / y   // Divides numerator by de-numerator
x % y   // Modulus Operator and remainder of after an integer division
x++     // Increment operator increases integer value by one
x--     // Decrement operator decreases integer value by one
          
// Relational Operators
(x == y)   // Checks if the values of two operands are equal
(x != y)   // Checks if the values of two operands are equal or not
(x > y)    // Checks if the value of left operand is greater than the value of right operand
(x < y)    // Checks if the value of left operand is less than the value of right operand
(x >= y)   // Checks if the value of left operand is greater than or equal to the value of right operand
(x <= y)   // Checks if the value of left operand is less than or equal to the value of right operand        

// Logical Operators
(x && y)   // Logical AND operator
(x || y)   // Logical OR Operator
!(x || y)  // Logical NOT Operator
```
<br/>
          
 # 🔻 <a name="decisao">Estrutura de decisão<a>
          
```c#
if(boolean_expression1)
{
   /* boolean expression 1 is true */
}
else if (boolean_expression2)
{
   /* boolean expression 2 is true */
}
else
{
   /* expression 1 and 2 are false */
}
          
```c#
switch(place)
{
   case 1  :
      Console.WriteLine("First!");
      break; 
   case 2  :
      Console.WriteLine("Second!");
      break; 
   default : /* Optional */
      Console.WriteLine("Invalid place!");
      break; 
}
```
<br/>
          
    
