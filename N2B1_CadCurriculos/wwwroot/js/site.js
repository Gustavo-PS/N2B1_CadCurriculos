
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
    if (countCurso > 1) {
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
        document.getElementById('dadosIdioma' + countIdioma).style.display = 'inline-block';
        document.getElementById("btnRemoveIdioma").style.display = 'inline-block';
        countIdioma++;
        console.log(countIdioma);
    }
}
function esconderIdioma() {
    if (countIdioma > 1) {
        document.getElementById('dadosIdioma' + (countIdioma - 1)).style.display = 'none';
        countIdioma--;
        console.log(countIdioma);
        if (countIdioma === 2) {
            document.getElementById("btnRemoveIdioma").style.display = 'none';
        }
    }
}

//var e functions dos campos de experiência
var countExperiencia= 2;
function showExperiencia() {
    if (countExperiencia <= 3) {
        document.getElementById('Experiencias' + countExperiencia).style.display = 'inline-block';
        document.getElementById("btnRemoveExperiencias").style.display = 'inline-block';
        countExperiencia++;
        console.log(countExperiencia);
    }
}
function esconderExperiencia() {
    if (countExperiencia > 1) {
        document.getElementById('Experiencias' + (countExperiencia - 1)).style.display = 'none';
        countExperiencia--;
        console.log(countExperiencia);
        if (countExperiencia === 2) {
            document.getElementById("btnRemoveExperiencias").style.display = 'none';
        }
    }
}

function cvInserido() {
    alert("Currículo inserido com sucesso!");
}


function CampoData() {
    for (var i = 1; i <= 5; i++) {
        var dtConclusao = document.getElementById("Conclusao" + i);
        var dtInicio = document.getElementById("Inicio" + i);
        var dtTermino = document.getElementById("Termino" + i);
        
        if (dtConclusao.value === "0001-01") {
            dtConclusao.value = null;
        }
        if (dtInicio.value === "0001-01") {
            dtInicio.value = null;
        }
        if (dtTermino.value === "0001-01") {
            dtTermino.value = null;
        }
    }
}
