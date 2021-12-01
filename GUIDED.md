
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

* [Iniciando](#iniciando)
* [Hello World](#hello-world)
* [Comments](#comments)
* [Variáveis](#variaveis)



# 🏁 <a name="iniciando">Iniciando<a>
<br/>

Antes de instalar o .NET, adicione a chave de assinatura do pacote da Microsoft à lista de chaves confiáveis e adicione o repositório de pacotes com os seguintes comandos:

```bash
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
```
<br/>

Após a conclusão, instale o SDK

```bash
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0
```
<br/>

E o RUNTIME:
```bash
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-5.0
```
<br/>

# 💻 Criando um novo projeto

```bash
dotnet new console
```
<br/>

Para executar, basta digitar no terminal:

```bash
dotnet run
```

<br/>

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
  

