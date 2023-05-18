class Pais{
    public string Nombre {get; private set;}
    public string imgBandera {get; private set;}
    public int Poblacion {get; private set;}
    public DateTime FechaIndependencia{get; private set;}
    public string AtractivosTuristicos {get; private set;}

    public Pais(string Nombre, string imgBandera, int Poblacion, DateTime FechaIndependencia, string AtractivosTuristicos){
        this.Nombre = Nombre;
        this.imgBandera = imgBandera;
        this.Poblacion = Poblacion;
        this.FechaIndependencia = FechaIndependencia;
        this.AtractivosTuristicos = AtractivosTuristicos;
    }
}