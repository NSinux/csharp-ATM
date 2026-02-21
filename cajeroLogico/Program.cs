class Program {
    /*This program is an ATM simulation, it allows User to interact as if it were an ATM*/
    static void Main() {
        //Variables
        bool salir = false;
        //Objetos
        Menu menuObj = new Menu();
        GeneralManager gmObj = new GeneralManager();
        UserManager umObj = new UserManager();

        while (!salir) {
            menuObj.imprimirMenu();
            string input = Console.ReadLine();

            switch (gmObj.verificarEntrada(input)) {
                case 1:
                    umObj.interfazUsuario(1);
                    break;
                case 2:
                    umObj.interfazUsuario(2);
                    break;
                case 3:
                    Console.WriteLine("Hasta pronto!!!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}