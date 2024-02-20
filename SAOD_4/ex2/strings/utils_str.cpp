void string_copy(char* s, char* t) {
	for (char* pd = t, *ps = s; *pd = *ps; pd++, ps++);
}

int len(const char* s) {
	int count = 0;
	for (const char* p = s; *p != 0; p++) {
		count++;
	}
	return count;
}

int compare(const char* s, const char* t) {

	if (len(s) == len(t)) {
		for (const char* ps = s, *pt = t; *ps != 0; ps++, pt++) {
			
			if (*ps != *pt) {
				if (*ps > *pt) return 1;
				else return -1;
			}
		}
		return 0;
	}
	else {
		if ((len(s) - len(t)) > 0) return 1;
		else return -1;
	}

}