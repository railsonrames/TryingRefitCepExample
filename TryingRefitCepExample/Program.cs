using Refit;
using System;
using System.Threading.Tasks;

namespace TryingRefitCepExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
            string searchedCep = "72250316";
            Console.WriteLine($"Consultado o CEP: {searchedCep}");
            var retrievedAddress = await cepClient.GetAddressByCepAsync(searchedCep);
            Console.WriteLine($"\nCEP: {retrievedAddress.Cep}\nLogradouro: {retrievedAddress.Logradouro}\nComplemento: {retrievedAddress.Complemento}\nBairro: {retrievedAddress.Bairro}\nLocalidade: {retrievedAddress.Localidade}\nEstado: {retrievedAddress.Uf}\nCódigo Ibge: {retrievedAddress.Ibge}\nGia: {retrievedAddress.Gia}");
            Console.ReadKey();
        }
    }
}
