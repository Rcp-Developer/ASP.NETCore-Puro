//Objeto literal
//para proteger o javascript do escopo de outros javascripts

let index = {

    pesquisar: function () {

        Fancybox.show([
            {
                src: "/Usuario/FrameExemplo",
                type: "iframe",
                preload: false,
                width: 1200,
                height: 800,
            },
        ]);
    },
    executaPesquisa: function () {

        let filtro = document.querySelector("#txtPesquisa").value;
        filtro = encodeURIComponent(filtro);

        HttpClient.get("/Usuario/SelectAll?filtro="+filtro)
            .then(function (retornoServidor) {
                return retornoServidor.json();
            })
            .then(function (obj) {
                index.carregaGrid(obj);
            })
            .catch(function (erro) {
                alert("Erro: " + erro);
            })
    },
    carregaGrid: function (obj) {

        let linhas = "";
        let table = document.querySelector("#tableResultado");
        let tbody = document.querySelector("#tbodyResultado");
        tbody.innerHTML = "";

        obj.forEach((item) => {

            linhas +=
                `<tr>
                    <td>${item.nome}</td>
                    <td>btn</td>
                <tr>`;
        });

        tbody.innerHTML = linhas;
        table.style.display = "table";
    }
};