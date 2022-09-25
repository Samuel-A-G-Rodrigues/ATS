<h1>Desafio Atração e Seleção</h1>

<h2>Restaurar Banco de Dados</h2>
<ol>
  <li>Para pegar a imagem Docker, execute o Windows Power Shell como Administrador</li>
  <li>Execute o comando: <br> docker pull samrodrigues/sqlserver_ats</li>
  <li>Quando o comando acima terminar de executar, execute o comando: <br> docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=123@Mudar" -p 1433:1433 samrodrigues/sqlserver_ats</li>
  <li>Através do Docker Desktop, em Containers, você deverá ver o Docker "reverent_lewin" com o Status "Running"</li>
</ol>

<h2>Rodar Solução da API</h2>
<ol>
  <li>Realizar Download ou clone do Repositório</li>
  <li>Abrir pasta ATSRestAPi</li>
  <li>Na pasta ATSRestAPi, abir o arquivo ATSRestApi.sln. A Solution será aberta no Visual Studio</li>
  <li>Na parte superior central do Visual Studio, clicar no botão Play (Cor verde) que está escrito "IIS Express" ou apertar "F5" no teclado</li>
  <li>Será aberto o Swagger</li>
</ol>

<h2>Importar Collections no Postman  (Realizar as ações abaixo para cada uma das URLS)</h2>
<ol>
  <li>Abrir o aplicativo Postman</li>
  <li>Clicar no botão Iimport</li>
  <li>Selecionar a opção Link</li>
  <li>Colocar URL no campo e clicar em Continue
     <h5>ATS Candidato</h5>
     https://www.getpostman.com/collections/be23937326e54267ea2b
     <h5>ATS Curriculo</h5>
     https://www.getpostman.com/collections/350b68785b365d0b19c3</li>
 </ol>
