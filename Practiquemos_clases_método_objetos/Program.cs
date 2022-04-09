using Practiquemos_clases_método_objetos;

Animal anim = new Animal();
Empleado Emp = new Empleado();
Transporte Tra = new Transporte();

anim.Crear_Animal("Perro","Pitbull","4","blanco","ladridos","croquetas");
Console.WriteLine("Animal" + " " + "Nombre: " + anim.Nombre1 + " " + "Tipo: " + anim.Tipo1 + " " + "Total de Patas: " + anim.Total_patas1 + " " + "Forma de comunicarse: " + anim.Forma_comunicar1 + " " + "Tipo de Alimento: " + anim.Tipo_Alimento1);

anim.Crear_Animal("Pollo", "gallina", "2", "blanco", "cacareo", "semillas");
Console.WriteLine("Animal" + " " + "Nombre: " + anim.Nombre1 + " " + "Tipo: " + anim.Tipo1 + " " + "Total de Patas: " + anim.Total_patas1 + " " + "Forma de comunicarse: " + anim.Forma_comunicar1 + " " + "Tipo de Alimento: " + anim.Tipo_Alimento1);

anim.Crear_Animal("Gato", "siames", "4", "Negro", "Maullo", "Atun");
Console.WriteLine("Animal" + " " + "Nombre: " + anim.Nombre1 + " " + "Tipo: " + anim.Tipo1 + " " + "Total de Patas: " + anim.Total_patas1 + " " + "Forma de comunicarse: " + anim.Forma_comunicar1 + " " + "Tipo de Alimento: " + anim.Tipo_Alimento1);

Emp.Crear_emp("Aldo","Administrador","Soltero", 3,"13 de enero del 2019",3);
Console.WriteLine("Empleado" + " " + "Nombre: " + Emp.Nombre1 + " " + "Estado Civill: " + Emp.Edo_Civil1 + " " + "Edad: " + Emp.Edad1 + " " + "Fecha de Nacimiento: " + Emp.Fecha_Nac1 + " " + "Antiguedad Laborando: " + Emp.Antiguedad_Lab1);

Emp.Crear_emp("Claudia","Analista","Viuda", 52,"12 de marzo de 1970",21);
Console.WriteLine("Empleado" + " " + "Nombre: " + Emp.Nombre1 + " " + "Estado Civill: " + Emp.Edo_Civil1 + " " + "Edad: " + Emp.Edad1 + " " + "Fecha de Nacimiento: " + Emp.Fecha_Nac1 + " " + "Antiguedad Laborando: " + Emp.Antiguedad_Lab1);

Emp.Crear_emp("Abelardo","Contador","Casado", 56,"06 de octubre de 1965",30);
Console.WriteLine("Empleado" + " " + "Nombre: " + Emp.Nombre1 + " " + "Estado Civill: " + Emp.Edo_Civil1 + " " + "Edad: " + Emp.Edad1 + " " + "Fecha de Nacimiento: " + Emp.Fecha_Nac1 + " " + "Antiguedad Laborando: " + Emp.Antiguedad_Lab1);

Tra.Crear_Tran("Tren ", "Azul ", "Tren de levitación magnética");
Console.WriteLine("Transporte" + " " + "Nombre: " + Tra.Nombre1 + " " + "Color: " + Tra.Color1 + " " + "Tipo: " + Tra.Tipo1);

Tra.Crear_Tran("Avión ", "verde ", "Airbus 300-600 ST.");
Console.WriteLine("Transporte" + " " + "Nombre: " + Tra.Nombre1 + " " + "Color: " + Tra.Color1 + " " + "Tipo: " + Tra.Tipo1);

Tra.Crear_Tran("Bicicleta ", "Negra ", "BMX. ");
Console.WriteLine("Transporte" + " " + "Nombre: " + Tra.Nombre1 + " " + "Color: " + Tra.Color1 + " " + "Tipo: " + Tra.Tipo1);

Console.ReadKey(true);