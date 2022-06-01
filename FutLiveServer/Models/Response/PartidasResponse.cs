
public class PartidasResponse
{
    public Clubes clubes { get; set; }
    public Partida[] partidas { get; set; }
    public int rodada { get; set; }
}

public class Clubes
{
    public _1371 _1371 { get; set; }
    public _262 _262 { get; set; }
    public _263 _263 { get; set; }
    public _264 _264 { get; set; }
    public _266 _266 { get; set; }
    public _275 _275 { get; set; }
    public _276 _276 { get; set; }
    public _277 _277 { get; set; }
    public _280 _280 { get; set; }
    public _282 _282 { get; set; }
    public _285 _285 { get; set; }
    public _286 _286 { get; set; }
    public _290 _290 { get; set; }
    public _293 _293 { get; set; }
    public _294 _294 { get; set; }
    public _314 _314 { get; set; }
    public _327 _327 { get; set; }
    public _354 _354 { get; set; }
    public _356 _356 { get; set; }
    public _373 _373 { get; set; }
}

public class _1371
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class Escudos
{
    public string _60x60 { get; set; }
    public string _45x45 { get; set; }
    public string _30x30 { get; set; }
}

public class _262
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _263
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _264
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _266
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _275
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _276
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _277
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _280
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _282
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _285
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _286
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _290
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _293
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _294
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _314
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _327
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _354
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _356
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class _373
{
    public int id { get; set; }
    public string nome { get; set; }
    public string abreviacao { get; set; }
    public Escudos escudos { get; set; }
    public string nome_fantasia { get; set; }
}

public class Partida
{
    public int partida_id { get; set; }
    public int clube_casa_id { get; set; }
    public int clube_casa_posicao { get; set; }
    public int clube_visitante_id { get; set; }
    public string[] aproveitamento_mandante { get; set; }
    public string[] aproveitamento_visitante { get; set; }
    public int clube_visitante_posicao { get; set; }
    public string partida_data { get; set; }
    public int timestamp { get; set; }
    public string local { get; set; }
    public bool valida { get; set; }
    public object placar_oficial_mandante { get; set; }
    public object placar_oficial_visitante { get; set; }
    public string status_transmissao_tr { get; set; }
    public string inicio_cronometro_tr { get; set; }
    public string status_cronometro_tr { get; set; }
    public string periodo_tr { get; set; }
    public Transmissao transmissao { get; set; }
}

public class Transmissao
{
    public string label { get; set; }
    public string url { get; set; }
}
