// Copyright 2013 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

#pragma once

#include "search_base.h"

class BoyerMooreSearch : public AsciiSearchBase {
 public:
  BoyerMooreSearch();
  virtual ~BoyerMooreSearch();

  virtual bool PreProcess(const char *pattern, int patternLen, SearchOptions options) OVERRIDE;
  virtual const char* Search(const char *text, int texLen) OVERRIDE;

 private:
  const char *pattern_;
  int patternLen_;
  bool matchCase_;
  int delta1_[kAlphabetLen];
  int *delta2_;
};
