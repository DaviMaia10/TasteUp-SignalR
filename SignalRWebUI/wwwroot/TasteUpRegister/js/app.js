/**
 * TasteUp - Register Page JavaScript
 * Basit form validasyonu
 */

const registerForm = document.getElementById('registerForm');
const strengthBar = document.getElementById('strengthBar');

// Form gönderimi
registerForm.addEventListener('submit', function(e) {
    // Basit validasyon
    const password = document.getElementById('password').value;
    const confirmPassword = document.getElementById('confirmPassword').value;
    const terms = document.getElementById('terms').checked;
    
    if (password !== confirmPassword) {
        e.preventDefault();
        alert('Şifreler eşleşmiyor!');
        return;
    }
    
    if (!terms) {
        e.preventDefault();
        alert('Kullanım şartlarını kabul etmelisiniz!');
        return;
    }
    
    // Form MVC controller'a gönderilecek
});

// Şifre güç göstergesi
document.getElementById('password').addEventListener('input', function(e) {
    const password = e.target.value;
    let strength = 0;
    
    if (password.length >= 8) strength++;
    if (/[a-z]/.test(password) && /[A-Z]/.test(password)) strength++;
    if (/\d/.test(password)) strength++;
    if (/[@$!%*?&]/.test(password)) strength++;
    
    strengthBar.className = 'strength-bar';
    if (password.length === 0) {
        strengthBar.style.width = '0';
    } else if (strength <= 1) {
        strengthBar.classList.add('weak');
    } else if (strength <= 3) {
        strengthBar.classList.add('medium');
    } else {
        strengthBar.classList.add('strong');
    }
});

// Şifre göster/gizle
function togglePassword(fieldId) {
    const field = document.getElementById(fieldId);
    field.type = field.type === 'password' ? 'text' : 'password';
}

window.togglePassword = togglePassword;
