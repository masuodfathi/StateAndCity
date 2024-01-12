$(document).ready(function () {
    $('#state').change(function () {
        var selectedStateId = $(this).val();

        // Reset city dropdown
        $('#city').val('');
        $('#city').prop('disabled', true);
        $('#cityImageContainer').hide();

        if (selectedStateId !== '') {
            // Fetch cities for the selected state using AJAX
            $.ajax({
                type: 'GET',
                url: '/SelectLocation/GetCitiesByState',
                data: { stateId: selectedStateId },
                success: function (data) {
                    // Update city dropdown
                    $('#city').empty();
                    $('#city').append('<option value="">-- Select City --</option>');

                    $.each(data, function (index, city) {
                        $('#city').append('<option value="' + city.cityId + '">' + city.cityName + '</option>');
                    });

                    $('#city').prop('disabled', false);
                    
                }
            });
        }
    });

    $('#city').change(function () {
        var cityImage = $('#cityImage');
        var selectedCityId = $(this).val();
        var cityImageContainer = $('#cityImageContainer');
        cityImageContainer.hide();
        if (selectedCityId !== '') {
            // Fetch city image path using AJAX
            $.ajax({
                type: 'GET',
                url: '/SelectLocation/GetCityImage',
                data: { cityId: selectedCityId },
                success: function (data) {
                    // Display city image
                    cityImage.attr('src', data);
                    cityImageContainer.show();
                }
            });
        } else {
            // Hide city image container if no city selected
            $('#cityImageContainer').hide();
        }
    });
});