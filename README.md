# AES-EAX
EAX is block cipher mode of operation which implements authenticated encryption with additional data (AEAD).
Given a nounce N, a message M, and a header H, EAX mode protects the privacy of M and the authenticity of both M and H.
EAX mode is two-pass schema, with one pass for achieving privacy and one for authenticity.

Schema description and its proof of security can be found in [M. Bellare, P. Rogaway and D. Wagner paper](http://web.cs.ucdavis.edu/~rogaway/papers/eax.pdf])

