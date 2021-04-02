
//Máscaras
var mask = {

    //Init
    init: function (o, f) {
        v_obj = o;
        v_fun = f;

        setTimeout("mask.execmasc()", 1);
    },

    //ExecMasc
    execmasc: function () {
        v_obj.value = v_fun(v_obj.value)
    },

    //Cep
    cep: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/^(\d{5})(\d)/, "$1-$2");

        document.getElementById("cep").maxLength = "9";

        return v;
    },

    //Tel
    tel: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/^(\d{2})(\d)/g, "($1) $2");
        v = v.replace(/(\d)(\d{4})$/, "$1-$2");

        document.getElementById("tel").maxLength = "15";

        return v;
    },

    //CPF
    Cpf: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/(\d{3})(\d)/, "$1.$2");
        v = v.replace(/(\d{3})(\d)/, "$1.$2");
        v = v.replace(/(\d{3})(\d{1,2})$/, "$1-$2");

        document.getElementById("Cpf").maxLength = "14";

        return v;
    },

    //Num
    num: function (v) {
        v = v.replace(/\D/g, "");

        return v;
    },

    //Date
    date: function (v) {
        v = v.replace(/\D/g, "");
        v = v.replace(/(\d{2})(\d)/, "$1/$2");
        v = v.replace(/(\d{2})(\d)/, "$1/$2");

        v = v.replace(/(\d{2})(\d{2})$/, "$1$2");

        return v;
    },

}

//var e function dos campos de cursos
var countCurso = 2;
function showCurso() {
    if (countCurso <= 5) {
        document.getElementById('Formacao' + countCurso).style.display = 'block';
        document.getElementById("btnRemoveCurso").style.display = 'inline-block';
        countCurso++;
        console.log(countCurso);
    }
}
function esconderCurso() {
    if (countCurso > 2) {
        document.getElementById('Formacao' + (countCurso - 1)).style.display = 'none';
        countCurso--;
        console.log(countCurso);
        if (countCurso === 2) {
            document.getElementById("btnRemoveCurso").style.display = 'none';
        }
    }
}

//var e functions dos campos de idioma
var countIdioma = 2;
function showIdioma() {
    if (countIdioma <= 3) {
        document.getElementById('dadosIdioma' + countIdioma).style.display = 'block';
        document.getElementById("btnRemoveIdioma").style.display = 'inline-block';
        countIdioma++;
        console.log(countIdioma);
    }
}
function esconderIdioma() {
    if (countIdioma > 2) {
        document.getElementById('dadosIdioma' + (countIdioma - 1)).style.display = 'none';
        countIdioma--;
        console.log(countIdioma);
        if (countIdioma === 2) {
            document.getElementById("btnRemoveIdioma").style.display = 'none';
        }
    }
}

//var e functions dos campos de experiência
var countExperiencia = 2;
function showExperiencia() {
    if (countExperiencia <= 3) {
        document.getElementById('Experiencias' + countExperiencia).style.display = 'inline-block';
        document.getElementById("btnRemoveExperiencias").style.display = 'inline-block';
        countExperiencia++;
        console.log(countExperiencia);
    }
}
function esconderExperiencia() {
    if (countExperiencia > 2) {
        document.getElementById('Experiencias' + (countExperiencia - 1)).style.display = 'none';
        countExperiencia--;
        console.log(countExperiencia);
        if (countExperiencia === 2) {
            document.getElementById("btnRemoveExperiencias").style.display = 'none';
        }
    }
}


//Function da view alteração: altera os campos com data = null e mostra as divs necessárias 
function CampoData() {
    //debugger;
    countCurso = 1;
    countExperiencia = 1;
    countIdioma = 1;
    for (var i = 1; i <= 5; i++) {
        var dtConclusao = document.getElementById("Conclusao" + i);
        var dtInicio = document.getElementById("Inicio" + i);
        var dtTermino = document.getElementById("Termino" + i);

        if (dtConclusao.value === "0001-01") {
            dtConclusao.value = null;
        }

        var divCurso = document.getElementById("Formacao" + i);
        var divExperiencia = document.getElementById("Experiencias" + i);
        var divIdioma = document.getElementById("dadosIdioma" + i);
        if (document.getElementById("Curso" + i).value != "") {
            console.log("mostrando a div de curso" + i);
            divCurso.style.display = 'block';
            countCurso++;
            document.getElementById("btnRemoveCurso").style.display = 'inline-block';
        }

        if (i <= 3) {
            if (dtInicio.value === "0001-01") {
                dtInicio.value = null;
            }

            if (dtTermino.value === "0001-01") {
                dtTermino.value = null;
            }

            if (document.getElementById("Empresa" + i).value != "") {
                console.log("mostrando a div de exp" + i);
                divExperiencia.style.display = 'block';
                countExperiencia++;
                document.getElementById("btnRemoveExperiencias").style.display = 'inline-block';
            }

            if (document.getElementById("Idioma" + i).value != "") {
                console.log("mostrando a div de idioma" + i);
                divIdioma.style.display = 'block';
                countIdioma++;
                document.getElementById("btnRemoveIdioma").style.display = 'inline-block';
            }
        }
    }

}

//Function da view impressao que oculta as divs nulas 
function ApagaCampos() {
    for (var i = 1; i <= 5; i++) {
        var divCurso = document.getElementById("divCurso" + i);
        var divExperiencia = document.getElementById("divExperiencia" + i);
        var divIdioma = document.getElementById("divIdioma" + i);
        if (document.getElementById("curso" + i).value === "") {
            console.log("apagando a div de curso" + i);
            divCurso.style.display = 'none';
        }

        if (i <= 3) {
            if (document.getElementById("empresa" + i).value === "") {
                console.log("apagando a div de exp" + i);
                divExperiencia.style.display = 'none';
            }

            if (document.getElementById("idioma" + i).value === "") {
                console.log("apagando a div de idioma" + i);
                divIdioma.style.display = 'none';
            }
        }
    }
}
