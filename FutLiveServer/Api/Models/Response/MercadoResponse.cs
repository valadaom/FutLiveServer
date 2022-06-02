public class MercadoResponse
{
    public Clubes clubes { get; set; }
    public Atleta[] atletas { get; set; }
}

public class Atleta
{
    public Scout scout { get; set; }
    public int atleta_id { get; set; }
    public int rodada_id { get; set; }
    public int clube_id { get; set; }
    public int posicao_id { get; set; }
    public int status_id { get; set; }
    public float pontos_num { get; set; }
    public float preco_num { get; set; }
    public float variacao_num { get; set; }
    public float media_num { get; set; }
    public int jogos_num { get; set; }
    public object minimo_para_valorizar { get; set; }
    public string slug { get; set; }
    public string apelido { get; set; }
    public string apelido_abreviado { get; set; }
    public string nome { get; set; }
    public string foto { get; set; }
}

public class Scout
{
    public int A { get; set; }
    public int CA { get; set; }
    public int DS { get; set; }
    public int FC { get; set; }
    public int FD { get; set; }
    public int FF { get; set; }
    public int FS { get; set; }
    public int FT { get; set; }
    public int G { get; set; }
    public int I { get; set; }
    public int PI { get; set; }
    public int DE { get; set; }
    public int GS { get; set; }
    public int PC { get; set; }
    public int SG { get; set; }
    public int PP { get; set; }
    public int GC { get; set; }
    public int CV { get; set; }
    public int PS { get; set; }
    public int DP { get; set; }
}
