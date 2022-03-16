var lowerSlider = document.getElementById('lower');
var upperSlider = document.getElementById('upper');

document.getElementById('to').innerHTML = upperSlider.value;
document.getElementById('from').innerHTML = lowerSlider.value;

var lowerVal = parseInt(lowerSlider.value);
var upperVal = parseInt(upperSlider.value);

upperSlider.oninput = function () {
    lowerVal = parseInt(lowerSlider.value);
    upperVal = parseInt(upperSlider.value);

    if (upperVal < lowerVal + 4) {
        lowerSlider.value = upperVal - 4;
        if (lowerVal == lowerSlider.min) {
            upperSlider.value = 4;
        }
    }
    document.getElementById('to').innerHTML = this.value;
    document.getElementById('from').innerHTML = lowerSlider.value;
};

lowerSlider.oninput = function () {
    lowerVal = parseInt(lowerSlider.value);
    upperVal = parseInt(upperSlider.value);

    if (lowerVal > upperVal - 4) {
        upperSlider.value = lowerVal + 4;
        if (upperVal == upperSlider.max) {
            lowerSlider.value = parseInt(upperSlider.max) - 4;
        }
    }
    document.getElementById('from').innerHTML = this.value;
    document.getElementById('to').innerHTML = upperSlider.value;
};

$('#lower').on('input', function () {
    $(this).css('background', 'linear-gradient(to right, #3BB77E 0%, #3BB77E ' + this.value * 100 / 2000 + '%, #d3d3d3 ' + this.value * 100 / 2000 + '%, #d3d3d3 100%)');
    $('#upper').css('background', 'linear-gradient(to right, #3BB77E 0%, #3BB77E ' + $('#upper').val() * 100 / 2000 + '%, #d3d3d3 ' + $('#upper').val() * 100 / 2000 + '%, #d3d3d3 100%)');
});

$('#upper').on('input', function () {
    $(this).css('background', 'linear-gradient(to right, #3BB77E 0%, #3BB77E ' + this.value * 100 / 2000 + '%, #d3d3d3 ' + this.value * 100 / 2000 + '%, #d3d3d3 100%)');
    $('#lower').css('background', 'linear-gradient(to right, #3BB77E 0%, #3BB77E ' + $('#lower').val() * 100 / 2000 + '%, #d3d3d3 ' + $('#lower').val() * 100 / 2000 + '%, #d3d3d3 100%)');
});