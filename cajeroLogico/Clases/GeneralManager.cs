class GeneralManager {
    //Metodos de comprobacion o logicos

    /*Este metodo nos ayuda a validar que el usuario no teclee
    alguna letra al momento de seleccionar alguna opcion del
    menu*/
    public int verificarEntrada(string input) {
        int valor;
        if (int.TryParse(input, out valor)) {
            return valor;
        }
        else {
            Console.WriteLine("Solo se permiten numeros en el selector de opciones");
            return 0;
        }
    }
    
    /*Este metodo permite validad que el usuario teclea letras
    en el NIP o este pone un NIP mayor o menor a 4 digitos*/
    public bool validadNIP(string nip) {
        int valor;
        if (int.TryParse(nip, out valor)) {
            if (nip.Length == 4) {
                return true;
            }
            else {
                Console.WriteLine("Se requiere una longitud de 4 digitos en tu NIP");
                return false;
            }
        }
        else {
            Console.WriteLine("Solo se permiten numeros en el NIP");
            return false;
        }
    }


    public string solicitarNIP() {
        Console.Write("Ingrese su NIP: ");
        return Console.ReadLine();
    }
}