class Menu {
    GeneralManager gmObj = new GeneralManager();
    public void imprimirMenu() {
        Console.WriteLine("\n- - - ATM - - -");
        Console.WriteLine("[1] Iniciar sesion");
        Console.WriteLine("[2] Registrarse");
        Console.WriteLine("[3] Salir");
        Console.Write("Selecciona una opcion: ");
    }

    public void imprimirMenuUsuario(){
        Console.WriteLine("\n- - - Menu de usuario - - -");
        Console.WriteLine("[1] Ingresar saldo");
        Console.WriteLine("[2] Retirar saldo");
        Console.WriteLine("[3] Consultar saldo");
        Console.WriteLine("[4] salir");
        Console.Write("Selecciona una opcion: ");
    }

}