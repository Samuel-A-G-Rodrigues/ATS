<h1>Desafio Atração e Seleção</h1>
<h2>Restaurar Banco de Dados</h2>
<ol>
<li>Para pegar a imagem Docker, execute o Windows Power Shell como Administrador</<li>>
<li>Execute o comando:
  docker pull samrodrigues/sqlserver_ats<li>
<li>Quando o comando acima terminar de executar, execute o comando: 
  docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=123@Mudar" -p 1433:1433 samrodrigues/sqlserver_ats<li>
<li>Através do Docker Desktop, em Containers, você deverá ver o Docker "reverent_lewin" com o Status "Running"<li>
</ol>
<h2>Rodar Solução da API</h2>
1- Realizar Download ou clone do Repositório
2- Abrir pasta ATSRestAPi
3- Na pasta ATSRestAPi, abir o arquivo ATSRestApi.sln. A Solution será aberta no Visual Studio
4- Na parte superior central do Visual Studio, clicar no botão Play (Cor verde) que está escrito "IIS Express" ou apertar "F5" no teclado
5- Será aberto o Swagger 

<h2>Importar Collections no Postman  (Realizar as ações abaixo para cada uma das URLS)</h2>
1- Abrir o aplicativo Postman
2- Clicar no botão Iimport
3- Selecionar a opção Link
4- Colocar URL no campo e clicar em Continue
   ATS Candidato
   https://www.getpostman.com/collections/be23937326e54267ea2b
   ATS Curriculo
   https://www.getpostman.com/collections/350b68785b365d0b19c3
