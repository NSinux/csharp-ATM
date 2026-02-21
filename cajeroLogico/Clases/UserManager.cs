class UserManager {
    // Lista
    List<User> userList = new List<User>();
    // Objetos
    GeneralManager gmObj = new GeneralManager();
    Menu menuObj = new Menu();
    public void interfazUsuario(int seleccion) {
        Console.WriteLine("`\n- - - - - - - - - - - - - -");
        Console.Write("Username: ");
        string userInput = Console.ReadLine();
        Console.Write("Password: ");
        string passInput = Console.ReadLine();

        if (seleccion == 1) {
            iniciarSesion(userInput, passInput);
        }
        if (seleccion == 2) {
            registrarUsuario(userInput, passInput, gmObj.solicitarNIP());
        }
    }

    public void iniciarSesion(string usuario, string contraseña) {
        if (verificarExistencia(usuario) && verificarContraseña(contraseña)) {
            menuUsuario(usuario);
        }
        else {
            Console.WriteLine("Error de inicio de sesion");
        }
    }

    public void registrarUsuario(string usuario, string contraseña, string nip) {
        if (gmObj.validadNIP(nip) == true) {
            if (verificarExistencia(usuario) == true) {
                Console.WriteLine("Este usuario ya existe!");
            }
            else {
                User user = new User(usuario, contraseña, Convert.ToInt32(nip), 0);
                userList.Add(user);
                Console.WriteLine("Usuario agregado");
            }
        }
    }

    public void ingresarSaldoCuenta(string usuario) {
        Console.WriteLine("\n- - - Ingresar saldo - - -");
        Console.Write("Cantidad a depositar: ");
        decimal saldoIngresado = Convert.ToDecimal(Console.ReadLine());
        User cuentaUsuario = userList.Find(u => u.USERNAME == usuario);
        cuentaUsuario.ingresarSaldo(saldoIngresado);
        Console.WriteLine("Saldo ingresado correctamente");
    }

    public void retirarSaldoCuenta(string usuario) {
        Console.WriteLine("\n- - - Retirar saldo - - -");
        Console.Write("Cantidad a retirar: ");
        decimal saldoRetirado = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese su NIP: ");
        string nip = Console.ReadLine();
        
        if (gmObj.validadNIP(nip)) {
            if (verificarNIP(Convert.ToInt32(nip)) == true) {
                User cuentaUsuario = userList.Find(u => u.USERNAME == usuario);
                cuentaUsuario.retirarSaldo(saldoRetirado);
                Console.WriteLine("Saldo retirado correctamente");
            }
        }
    }

    public void consultarSaldoCuenta(string usuario) {
        User cuentaUsuario = userList.Find(u => u.USERNAME == usuario);
        Console.WriteLine($"Saldo de {cuentaUsuario.BALANCE}");
    }

    //Metodo para validar la existencia del usuario
    public bool verificarExistencia(string nombre) {
        for (int i = 0; i < userList.Count; i++) {
            if (userList[i].USERNAME == nombre) {
                return true;
            }
        }
        return false;
    }

    public bool verificarContraseña(string contraseña) {
        for (int i = 0; i < userList.Count; i++) {
            if (userList[i].PASSWORD == contraseña) {
                return true;
            }
        }
        return false;
    }

    public bool verificarNIP(int nip) {
        for (int i = 0; i < userList.Count; i++) {
            if (userList[i].NIP == nip) {
                return true;
            }
        }
        return false;
    }

    public void menuUsuario(string usuario) {
        bool salir = false;
        Console.WriteLine($"Bienvenido {usuario}");
        while (!salir) {
            menuObj.imprimirMenuUsuario();
            string input = Console.ReadLine();
            switch (gmObj.verificarEntrada(input)) {
                case 1:
                    ingresarSaldoCuenta(usuario);
                    break;
                case 2:
                    retirarSaldoCuenta(usuario);
                    break;
                case 3:
                    consultarSaldoCuenta(usuario);
                    break;
                case 4:
                    salir = true;
                    Console.WriteLine("Hasta pronto!!!");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}