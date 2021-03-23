using System;

namespace PracticaParcial
{
    class MetodosDispensadora
    {

public  int acumulador = 0;
       public int deposito;

        public void DispensadoraAlimentos()
        {

            int opcion;
            bool salir = false;
            

            int[] StockProductos = new int[10];

            StockProductos[0] = 15;
            StockProductos[1] = 10;
            StockProductos[2] = 7;
            StockProductos[3] = 10;
            StockProductos[4] = 5;
            StockProductos[5] = 9;
            StockProductos[6] = 8;
            StockProductos[7] = 20;
            StockProductos[8] = 3;
            StockProductos[9] = 6;

            while (salir != true)
            {
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("|           Menú de opciones    |");
                Console.WriteLine("|-------------------------------|");
                Console.WriteLine("1. Coca Cola 500 ml. 25 Pesos, cantidad: " + StockProductos[0]);
                Console.WriteLine("2. Botella de Agua Dasani 500 ml. 20 Pesos, cantidad: " + StockProductos[1]);
                Console.WriteLine("3. Lays Queso. 25 Pesos, cantidad: " + StockProductos[2]);
                Console.WriteLine("4. Doritos Sabor Pizza. 20 Pesos, cantidad: " + StockProductos[3]);
                Console.WriteLine("5. Hojuelitas de Queso. 10 Pesos, cantidad: " + StockProductos[4]);
                Console.WriteLine("6. Hojuelitas de Salsa BBQ. 10 Pesos, cantidad: " + StockProductos[5]);
                Console.WriteLine("7. Malta Morena 500 ml. 30 Pesos, cantidad: " + StockProductos[6]);
                Console.WriteLine("8. Mani De Limón. 15 Pesos, cantidad: " + StockProductos[7]);
                Console.WriteLine("9: Galleta Oreo. 15 Pesos, cantidad: " + StockProductos[8]);
                Console.WriteLine("10. Red Rock Uva 500ml. 20 Pesos, cantidad: " + StockProductos[9]);
                Console.WriteLine("11. Ver informe de venta.");
                Console.WriteLine("12. Salir.");
                Console.WriteLine("Elija una opción del menú (1-12)");
                Console.WriteLine(" ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("Haz seleccionado Coca Cola 500 ml.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[0] -= 1;
                            if (deposito > 25)
                            {
                                int devuelta1 = deposito - 25;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;


                    case 2:
                        Console.WriteLine("haz seleccionado Botella de Agua Dasani 500 ml.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[1] -= 1;
                            if (deposito > 20)
                            {
                                int devuelta1 = deposito - 20;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("haz seleccionado Lays de Queso.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[2] -= 1;
                            if (deposito > 25)
                            {
                                int devuelta1 = deposito - 25;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Haz seleccionado Doritos Sabor a Pizza");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra");
                            acumulador = acumulador + deposito;
                            StockProductos[3] -= 1;
                            if (deposito > 20)
                            {
                                int devuelta1 = deposito - 20;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Haz seleccionado Hojuelitas de Queso. ");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra");
                            acumulador = acumulador + deposito;
                            StockProductos[4] -= 1;
                            if (deposito > 10)
                            {
                                int devuelta1 = deposito - 10;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Haz seleccionado Hojuelitas de Salsa BBQ.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[5] -= 1;
                            if (deposito > 10)
                            {
                                int devuelta1 = deposito - 10;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Haz elegido Malta Morena 500 ml.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[6] -= 1;
                            if (deposito > 30)
                            {
                                int devuelta1 = deposito - 30;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Haz elegido Mani De Limon.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[7] -= 1;
                            if (deposito > 15)
                            {
                                int devuelta1 = deposito - 15;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 9:
                        Console.WriteLine("Haz elegido Galleta Oreo");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra.");
                            acumulador = acumulador + deposito;
                            StockProductos[8] -= 1;
                            if (deposito > 15)
                            {
                                int devuelta1 = deposito - 15;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;

                    case 10:
                        Console.WriteLine("Haz elegido Red Rock Uva 500 ml.");
                        Console.WriteLine("Inserte la papeleta ya sea de (50,100,200) o monedas de (5,10,25): ");
                        deposito = Convert.ToInt32(Console.ReadLine());
                        if ((deposito == 5) || (deposito == 10) || (deposito == 25) || (deposito == 50) || (deposito == 100) || (deposito == 200))
                        {
                            Console.WriteLine("El monto insertado es: " + deposito);
                            Console.WriteLine("Puede recoger su producto. Gracias por su compra");
                            acumulador = acumulador + deposito;
                            StockProductos[9] -= 1;
                            if (deposito > 20)
                            {
                                int devuelta1 = deposito - 20;
                                Console.WriteLine("Su devuelta es de: " + devuelta1);
                                acumulador -= devuelta1;
                            }
                            else
                            {
                                Console.WriteLine("No le sobra efectivo/monedas.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("El dispensador no permite esa cantidad.");
                        }
                        break;






                    case 11:
                        Console.WriteLine("| Stock de productos vendidos y cantidad disponibles |");
                        Console.WriteLine("1. Coca Cola 500 ml. 25 Pesos, cantidades disponibles: " + StockProductos[0] + " de: 15");
                        Console.WriteLine("2. Botella de Agua Dasani 500 ml. 20 Pesos, cantidades disponibles: " + StockProductos[1] + " de: 10");
                        Console.WriteLine("3. Lays Queso. 25 Pesos, cantidades disponibles: " + StockProductos[2] + " de: 7");
                        Console.WriteLine("4. Doritos Sabor Pizza. 20 Pesos, cantidades disponibles: " + StockProductos[3] + " de: 10");
                        Console.WriteLine("5. Hojuelitas de Queso. 10 Pesos, cantidades disponibles: " + StockProductos[4] + " de: 5");
                        Console.WriteLine("6. Hojuelitas de Salsa BBQ. 10 Pesos, cantidades disponibles: " + StockProductos[5] + " de: 9");
                        Console.WriteLine("7. Malta Morena 500 ml. 30 Pesos, cantidad disponibles: " + StockProductos[6] + " de: 8");
                        Console.WriteLine("8. Mani De Limon. 15 Pesos, cantidades disponibles: " + StockProductos[7] + " de: 20");
                        Console.WriteLine("9: Galleta Oreo. 15 Pesos, cantidades disponibles: " + StockProductos[8] + " de: 3");
                        Console.WriteLine("10. Red Rock Uva 500ml. 20 Pesos, cantidades disponibles: " + StockProductos[9] + " de: 6");
                        Console.WriteLine("");
                        Console.WriteLine("Total vendido: "+acumulador);


                        break;





                    case 12:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Debe elegir una opción del (1-12).");
                        break;


                }

            }

        }

   









        
    }
    
}