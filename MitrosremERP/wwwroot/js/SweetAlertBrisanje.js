
function confirmDelete(ime, prezime) {
    // Dohvati CSRF token iz forme
    var csrfToken = $('input[name="__RequestVerificationToken"]').val();

    
    var data = {
        __RequestVerificationToken: csrfToken
    };

    Swal.fire({
        title: 'Da li ste sigurni?',
        text: 'Upravo cete obrisati  ' + ime + " " + prezime,
        icon: 'warning',
        showConfirmButton: true,
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Da, obrisi!',
        cancelButtonText: 'Otkazi'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: '@Url.Action("DeletePost", "Zaposleni", new { id = Model.Id })', 
                type: 'POST',
                data: data,
                success: function (response) {
                    Swal.fire({
                        title: 'Obrisano!',
                        text: ime + " " + prezime + ' je obrisan.',
                        icon: 'success',
                        timer: 2500,
                        showConfirmButton: false
                    });

                    setTimeout(function () {
                        window.location.href = '@Url.Action("Index", "Zaposleni")'; 
                    }, 3000);
                },
                error: function (error) {
                    
                }
            });
        }
    });
}


   // function confirmDelete(ime,prezime) {
   //     Swal.fire({
   //         title: 'Da li ste sigurni?',
   //         text: 'Upravo cete obrisati  ' + ime + " " + prezime,
   //         icon: 'warning',
   //         showConfirmButton: true,
   //         showCancelButton: true,
   //         confirmButtonColor: '#3085d6',
   //         cancelButtonColor: '#d33',
   //         confirmButtonText: 'Da, obrisi!',
   //         cancelButtonText: 'Otkazi'
   //     }).then((result) => {
   //         if (result.isConfirmed) {
   //             $.ajax({
   //                 url: '@Url.Action("DeletePost", "Zaposleni", new { id = Model.Id })', // Pravilan URL za vašu akciju
   //                 type: 'DELETE',
   //                 data: data,
   //                 success: function (response) {

   //                 },
   //                 error: function (error) {
   //                     // Obrada grešaka
   //                     // Handle errors, such as displaying an error message to the user.
   //                 }
   //             });

   //             Swal.fire({
   //                 title: 'Obrisano!',
   //                 text: ime + " " + prezime + ' je obrisan.',
   //                 icon: 'success',
   //                 timer: 2500, 
   //                 showConfirmButton: false 
   //             });
   //             setTimeout(function () {
   //                 document.querySelector('form').submit();
   //             }, 3000); 

   //         }
   //     });
   //}
     
