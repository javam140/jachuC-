private List<int> pierwsze(int alfa, int omega)
{
    if (alfa > 2) alfa = 2;
    List<int> lista = new List<int>();
    bool[] tablica = new bool[omega+1];
    for (int i = 0; i <=omega; i++) tablica[i] = true;
    for (int i = 2; i*i<=omega;i++)
        if (tablica[i]) 
            for (int j = i * i; j <= omega;) tablica[j] = false;
    
    for (int i = alfa; i <= omega; i++) {
        if (tablica[i])
        {
            lista.Add(i);
        }
    }
    return lista;
}
