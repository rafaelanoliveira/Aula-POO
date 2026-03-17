using Formas;

Triangulo area = new Triangulo();
Console.WriteLine("Digite a base do triângulo: ");
area.rlado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do triângulo: ");
area.raltura = Convert.ToDouble(Console.ReadLine());

area.escalar(area.rlado, area.raltura);

Retangulo Rarea = new Retangulo();
Console.WriteLine("Digite o lado do retângulo");
Rarea.lado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do retângulo:");
Rarea.altura = Convert.ToDouble(Console.ReadLine());

Rarea.calcular(Rarea.lado, Rarea.altura);
