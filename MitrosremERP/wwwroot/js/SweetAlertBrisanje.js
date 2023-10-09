 
    function confirmDelete(ime,prezime) {
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
                Swal.fire({
                    title: 'Obrada...',
                    text: 'Molimo sačekajte...',
                    icon: 'info',
                    allowOutsideClick: false, 
                    showConfirmButton: false 
                });

                Swal.fire({
                    title: 'Obrisano!',
                    text: ime + " " + prezime + ' je obrisan.',
                    icon: 'success',
                    timer: 2500, 
                    showConfirmButton: false 
                });
                setTimeout(function () {
                    document.querySelector('form').submit();
                }, 3000); 

            }
        });
   }
     
