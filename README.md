# Sentiment Analysis Demo

> This repo is the sample code for the article created for the GFT Technology Journal

Feel free to clone / fork this repository, after downloading it in your environment (Windows / MAC / Linux) follow these steps to run the project.

## Step to Run

1. Create an Azure account in [Create Azure Account](https://azure.microsoft.com/en-us/free/search/?&OCID=AID2000058_SEM_XdCuggAAAErkUnt4:20200506122542:s&msclkid=5c7b256d19e51a58caef7bdfb5248341&ef_id=XdCuggAAAErkUnt4:20200506122542:s&dclid=CjgKEAjwwMn1BRDVy66apPPNjRwSJAA9o9Vvgib6eiV4cBs4-yAVc1JZd88CCy4Ru4mLtD84EEhP2vD_BwE)
2. Create a Cognitive Services
3. Change endpoint and key access in this fields.

   ```csharp
    private static readonly string key = "<Key Access>";
    private static readonly string endpoint = "<Endpoint>";
   ```

4. Run

    ```powershell
        dotnet restore
        dotnet build
        dotnet run
    ```

> Let me know if you have any questions or advice and if you liked the example and the article.
