namespace TP04_Bis_Aboudara.Models;
public static class Info{
    private static List<Pais> ListaPaises = new List<Pais>();
    private static Dictionary<string, int> idPais = new Dictionary<string, int>();

    private static void IniciarLista(){
        ListaPaises.Add(new Pais("Argentina", "/Fotos/Argentina.jpg", 45810000, new DateTime(1816,7,9), "Las Cataratas del Iguazú, Ciudad de Buenos Aires, El Glaciar Perito Moreno, Bariloche, Ushuaia"));
        ListaPaises.Add(new Pais("Sudáfrica", "/Fotos/Sudáfrica.jpg", 59390000, new DateTime(1961,5,31), "Ciudad del Cabo, Parque Nacional Kruger, La Ruta Jardín, Robben Island, Viñedos de Stellenbosch"));
        ListaPaises.Add(new Pais("Portugal", "/Fotos/Portugal.jpg", 10330000, new DateTime(1143,10,5), "Lisboa, Oporto, El Algarve, Sintra, Douro Valley"));
        ListaPaises.Add(new Pais("Rusia", "/Fotos/Rusia.jpg", 143400000, new DateTime(1991,12,25), "Moscú, San Petersburgo, Anillo de Oro, Lago Baikal, Transiberiano"));
        ListaPaises.Add(new Pais("Canadá", "/Fotos/Canadá.jpg", 38250000, new DateTime(1867,7,1), "Las Cataratas del Niágara, Parque Nacional Banff, Ciudad de Quebec, Vancouver, Isla del Príncipe Eduardo"));
        idPais.Add("Argentina", 0);
        idPais.Add("Sudáfrica", 1);
        idPais.Add("Portugal", 2);
        idPais.Add("Rusia", 3);
        idPais.Add("Canadá", 4);
    }
    
    public static List<Pais> ListarPaises(){
        if (ListaPaises.Count() == 0)
            IniciarLista();
        return ListaPaises;
    }
    public static Pais DetallePais(string Nombre){
        if (!idPais.ContainsKey(Nombre))
            return null;
        return ListaPaises[idPais[Nombre]];
    }
    
}