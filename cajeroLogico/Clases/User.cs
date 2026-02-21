class User {
    // User object attributes
    public string USERNAME {get; private set;}
    public string PASSWORD {get; private set;}
    public int NIP {get; private set;}
    public decimal BALANCE {get; private set;}

    //Constructor
    public User(string username, string password, int nip, decimal balance) {
        USERNAME = username;
        PASSWORD = password;
        NIP = nip;
        BALANCE = balance;
    }

    public void ingresarSaldo(decimal saldoIngresado) {
        if (saldoIngresado > 0) {
            BALANCE += saldoIngresado;
        }
    }

    public bool retirarSaldo(decimal saldoRetirado) {
        if (saldoRetirado > 0 && saldoRetirado <= BALANCE) {
            BALANCE -= saldoRetirado;
            return true;
        }
        else {
            return false;
        }
    }
}