# Contributing

Bu projeye katkı sağlamak için lütfen aşağıdaki `Conventional Commits` kurallarını takip edin. Bu kurallar sürüm notlarının (release notes) otomatik üretilmesine yardımcı olur ve sürüm yükseltme kararlarını netleştirir.

## Commit formatı (kısa)

Commit mesajları şu formatta olmalıdır:

```
<type>(<scope>)?: <short summary>

<optional body>

<optional footer>
```

- `type`: commit türü (aşağıda listelenenlerden biri)
- `scope`: isteğe bağlı; etkilenen modül veya alan (ör. `auth`, `api`)
- `short summary`: 50 karakteri geçmeyen, emir kipiyle kısa açıklama

Önemli `type` değerleri:

- `feat`: yeni bir özellik eklenmesi
- `fix`: bir hatanın düzeltilmesi
- `docs`: sadece dokümantasyon değişiklikleri
- `refactor`: kodun yeniden düzenlenmesi (işlevsellik değişmiyor)
- `chore`: bakım görevleri (örn. bağımlılık güncellemesi, build değişiklikleri)

## Örnek commit mesajları

- `feat(auth): add OAuth2 login flow`
- `fix(api): handle null response from users endpoint`
- `docs: update README with local setup steps`
- `chore(deps): bump Microsoft.Extensions.* packages`
- `refactor(user-service): simplify user lookup logic`

## Breaking change (kırıcı değişiklik) nasıl yazılır

Kırıcı değişiklikleri belirtmek için iki yöntem kullanın:

1. Türün sonuna ünlem işareti koyun (type! veya type(scope)!):

   - `feat!: change auth token format`
   - `refactor(auth)!: remove legacy token support`

2. Veya normal commit gövdesi/footeri içinde `BREAKING CHANGE:` başlığı kullanın:

```
feat(auth): remove deprecated login endpoint

BREAKING CHANGE: /api/login endpoint removed. Use /api/authenticate instead.
```

Bu iki yöntem birlikte de kullanılabilir; otomasyon araçları hem `!` işaretini hem de `BREAKING CHANGE:` footer'ını algılar.

## Neden release notes otomasyonuna yardımcı olur?

`Conventional Commits` yapısı, commit mesajlarını makine tarafından okunabilir hale getirir. Böylece araçlar (ör. `semantic-release`, GitHub release notes generator veya benzer CI/CD araçları):

- Hangi commitlerin yeni özellik (`feat`) veya hata düzeltmesi (`fix`) olduğunu ayırt edebilir,
- `BREAKING CHANGE` işaretlerini tespit ederek `major` sürüm arttırmaya karar verebilir,
- Otomatik olarak changelog/release notes oluşturabilir ve sürüm numarası belirleyebilir.

Kısaca: düzenli commit mesajları insanlara açıklık sağlar ve sürüm/sürüm notu üretimini güvenilir şekilde otomatikleştirir.

---

Kısa kurallar hatırlatması:

- Commit başlığını 50 karakter civarında ve emir kipinde tutun.
- Gerekli ise `scope` kullanın (modül/alan belirtmek için).
- Kırıcı değişikliklerde `!` veya `BREAKING CHANGE:` kullanın ve geçiş adımlarını footer'da belirtin.

Teşekkürler! Bu kurala uyduğunuz için otomatik sürüm notları ve sürüm yönetimi daha sorunsuz olacaktır.
