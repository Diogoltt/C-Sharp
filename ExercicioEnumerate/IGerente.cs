namespace ExerciciosEnumerate
{
    public interface IGerente
    {
        public void Autorizar();
        public bool ConcedeAumento();
        public bool AutorizaLicenca(Empregado empregado);
    }
}