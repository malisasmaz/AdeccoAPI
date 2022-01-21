# AdeccoAPI

# Preconditions

1. Visual Studio 2019+
2. .NET Core 3.1+
3. Postman(optional)<br />
The programs in above must be installed.

# Steps to Run this Project

1. Clone the repo
```sh
git clone https://github.com/malisasmaz/AdeccoAPI.git
```
2. Open in Visual Studio.

# Decision-Making Process and TechStack

1. I used ASP.NET Core Web Api template for the project. I added Services folder for my sub proccess.
2. Nuget packages and why I use them
   - PokeApiNet
     - The purpose of this is not to waste time creating a property class for the API
4. I added one endpoint to the API:
   - Pokemon
     - Contains two different GET operations. 
       - Get all pokemons
       - Get pokemons by name or id
