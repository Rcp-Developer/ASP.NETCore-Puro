let HttpClient = {

    post: function(url, dados) {

        let config = {
            method: "POST",
            body: JSON.stringify(dados),
            headers: {
                "Content-Type": "application/json"
            }
        }

        let promisse = fetch(url, config);

        return promisse;
    },
    get: function (url) {
        let config = {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        }

        let promisse = fetch(url, config);

        return promisse;
    }
}