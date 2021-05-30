function insertWsrefGetForm() {
    $('#div1').load('http://localhost:56754/insert');
}

function updateWsrefGetForm(id){
    $('#div-'+id).load('http://localhost:56754/update/'+id);
}

function deleteWsrefGetForm(id) {
    $('#div-'+id).load('http://localhost:56754/delete/' + id);
}

function commentsWsrefGetForm(id) {
    $('#div-' + id).load('http://localhost:56754/comments/' + id);
}

function insertCommentsWsrefGetForm(id) {
    $('#div-' + id + '-comments').load('http://localhost:56754/commentsinsert/' + id);

}


function clearDiv(id) {
    $(id).html("")
}