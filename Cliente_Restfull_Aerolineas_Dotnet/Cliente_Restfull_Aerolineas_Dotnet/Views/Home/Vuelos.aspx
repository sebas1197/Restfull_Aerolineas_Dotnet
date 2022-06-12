

<style>
    h1 {
        margin-top: 20px;
        text-align: center;
        color: blue;
        font-size: 60px;
    }
</style>

<h1>Lista de vuelos</h1>

<table class="table table-striped">
    <thead>
        <tr>
            <th scope="col">Ciudad de origen</th>
            <th scope="col">Ciudad de destino</th>
            <th scope="col">Valor</th>
            <th scope="col">Hora de salida</th>
        </tr>
    </thead>
    <tbody id="tcuerpo">

    </tbody>
</table>

<script>
    const url = 'http://localhost:50132/api/Vuelos';
    $.get(url, (obj) => {
        let result = '';
        $.each(obj, (index, element) => {
            result += `<tr>`;
            result += `<td> ${element.ciudad_origen}</td>`;
            result += `<td> ${element.ciudad_destino}</td>`;
            result += `<td> ${element.valor}</td>`;
            result += `<td> ${element.hora_salida}</td>`;
            result += `</tr>`;
        })
        $('#tcuerpo').html = result;
    })

</script>