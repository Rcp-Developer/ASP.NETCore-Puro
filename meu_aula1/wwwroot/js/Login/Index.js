//Objeto literal
//para proteger o javascript do escopo de outros javascripts

let index = {

    logar: function () {
        //Ambos fazem o mesmo
        /*
         * pela classe
        let email = querySelectorAll(".email")

        Pelo ID
        let email = document.querySelector("#email");
        let email = document.getElementById("email");
        */

        /*JSON
        Serializar
        De Objeto para Json/String

        Desserializar
        De Json/String para Objeto
        */

        let email = document.querySelector("#email");
        let senha = document.querySelector("#senha");
        /*let dados = {
            Email: email.value,
            Senha: senha.value
        };*/

        HttpClient.post("Login/Logar", {
            Email: email.value,
            Senha: senha.value
        })
            .then(function (retornoServidor) {
                return retornoServidor.json();
            })
            .then(function (obj) {
                if (obj.sucesso) {
                    //Redirecionamento, neste caso para Home, então irá para a Controladora HomeController/Index por padrão
                    window.location.href = "Home"; 
                }
                else
                    alert(obj.msg);
            })
            .catch(function () {
                alert("Deu exceção de erro.");
            })
    },
    recuperarSenha: function () {

    }
};