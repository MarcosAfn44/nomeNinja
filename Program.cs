Console.Write("Digite seu nome:"); 
string nomeDigitado = Console.ReadLine()!; 

string nomeNinja = nomeDigitado  
    .ToLower() 
    .Replace("a", "KA") 
    .Replace("á", "KA") 
    .Replace("ã", "KA") 
    .Replace("b", "ZU") 
    .Replace("c", "MI") 
    .Replace("d", "TE") 
    .Replace("e", "KU") 
    .Replace("f", "LU") 
    .Replace("g", "JI") 
    .Replace("h", "RI") 
    .Replace("i", "KI") 
    .Replace("í", "KI") 
    .Replace("j", "ZU") 
    .Replace("k", "ME") 
    .Replace("l", "TA") 
    .Replace("m", "RIN") 
    .Replace("n", "TO") 
    .Replace("o", "MO") 
    .Replace("õ", "MO") 
    .Replace("ô", "MO") 
    .Replace("ó", "MO") 
    .Replace("p", "NO") 
    .Replace("q", "KE") 
    .Replace("r", "SHI") 
    .Replace("s", "ARI") 
    .Replace("t", "CHI") 
    .Replace("u", "DO") 
    .Replace("v", "RU") 
    .Replace("w", "MEI") 
    .Replace("x", "NA") 
    .Replace("y", "FU") 
    .Replace("z", "ZI") 
    .ToLower(); 
    
    string inicial = nomeNinja.Substring(0,1).ToUpper(); 
    string restante = nomeNinja.Substring(1); 

nomeNinja = $"{inicial}{restante}";
