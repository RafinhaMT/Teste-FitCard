// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {    
    $('.cnpj').mask('00.000.000/0000-00', { reverse: true, clearIfNotMatch: true });
    $('.agencia').mask('000-0', { reverse: true, clearIfNotMatch:true });
    $('.conta').mask('00.000-0', { reverse: true, clearIfNotMatch: true });
    $('.telefone').mask('(00) 0000-0000');
    $('.cnpj').on('blur', function () {
        var cnpj = $('.cnpj').val().replace(/[^0-9]/g, '');

        if (cnpj.length == 14) {
            $.ajax({
                url: 'https://www.receitaws.com.br/v1/cnpj/' + cnpj,
                method: 'GET',
                dataType: 'jsonp',
                complete: function (xhr) {

                    response = xhr.responseJSON;

                    if (response.status == 'OK') {
                        $('.razaoSocial').val(response.nome);
                        $('.nomeFantasia').val(response.fantasia);
                        $('.email').val(response.email);
                        $('.endereco').val(response.logradouro);                      
                        $('.telefone').val(response.telefone);
                        $('.cidade').val(response.municipio);
                        $('.estado').val(response.uf);
                    } 
                }
            });
        } 
    })
});