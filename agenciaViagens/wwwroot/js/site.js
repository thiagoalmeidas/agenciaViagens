// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/* Tratando as imagens de topo para facilitar o Js do Csharp*/
const body = document.querySelector("body");
const title = document.querySelector("title");

if (title.text != "Home") {
    body.classList.add('img-background-2');
} else {
    body.classList.add('img-background');
}

/* Pegando os dados da inputs da página destinos exibindo no ticket */
if (title.text === "Destinos") {
    const btn = document.querySelector("#consultar");
    let ticket = document.querySelector(".display-check");
    btn.addEventListener("click", function (e) {
        e.preventDefault();
        ticket.style.display = 'flex';
    })

    let getorigem = document.getElementsByName('getorigem')[0];
    getorigem.addEventListener('input', function (e) {
        e.preventDefault();
        document.getElementById("result1").innerHTML = this.value;
    })
    let getdestino = document.getElementsByName('getdestino')[0];
    getdestino.addEventListener('input', function (e) {
        e.preventDefault();
        document.getElementById("result2").innerHTML = this.value;
    })
    let dataEmbarque = document.querySelector(".date-embarque");
    dataEmbarque.addEventListener('input', function (e) {
        e.preventDefault();
        document.getElementById("result3").innerHTML = this.value;
    })
    let dataRetorno = document.querySelector(".date-retorno");
    dataRetorno.addEventListener('input', function (e) {
        e.preventDefault();
        document.getElementById("result4").innerHTML = this.value;
    })
}
