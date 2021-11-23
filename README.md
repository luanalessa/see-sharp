
# <p align = "center"> C Sharp </p>

 <p align = "center">
  <a href="https://docs.microsoft.com/pt-br/dotnet/csharp/">C#</a> é uma linguagem de programação orientada a objetos, de tipagem forte,<br/>desenvolvida pela <strong>Microsoft</strong> como parte da plataforma <a href ="https://docs.microsoft.com/pt-br/dotnet/fundamentals/">.NET</a>. 
</p>

<br/>

# 🏁 Iniciando
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

# 💻 Criando projeto no Visual Studio Code

```bash
dotnet new console
```
<br/>

Para executar, basta digitar no terminal:

```bash
dotnet run
```

<br/>
<br/>

